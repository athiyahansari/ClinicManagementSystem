﻿

using CMS.Model;
using CMS.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace CMS.Controller
{
    public class DoctorsController
    {
        public List<Doctors> GetAllDoctors()
        {
            List<Doctors> doctors = new List<Doctors>();
            string query = "SELECT * FROM doctors";

            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            foreach (DataRow row in dt.Rows)
                            {
                                Doctors doctor = new Doctors
                                {
                                    DoctorId = Convert.ToInt32(row["doctor_id"]),
                                    UserId = Convert.ToInt32(row["user_id"]),
                                    FullName = row["full_name"].ToString(),
                                    Specialty = row["specialty"].ToString(),
                                    Consultation = Convert.ToDecimal(row["consultation"]),
                                    TotalPatients = Convert.ToInt32(row["total_patients"]),
                                    Email = row["email"].ToString(),
                                    Contact = row["contact"].ToString(),
                                    CreatedAt = Convert.ToDateTime(row["created_at"])
                                };
                                doctors.Add(doctor);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Failed to fetch doctors: " + ex.Message);
            }

            return doctors;
        }

        public DoctorProfile GetDoctorProfileById(int doctorId)
        {
            string query = $"SELECT * FROM doctor_profiles WHERE doctor_id = {doctorId} LIMIT 1";
            DoctorProfile profile = null;

            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                DataRow row = dt.Rows[0];
                                profile = new DoctorProfile
                                {
                                    ProfileId = Convert.ToInt32(row["profile_id"]),
                                    DoctorId = Convert.ToInt32(row["doctor_id"]),
                                    Description = row["description"].ToString(),
                                    Speciality = row["speciality"].ToString(),
                                    Email = row["email"].ToString(),
                                    Contact = row["contact"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Failed to fetch doctor profile: " + ex.Message);
            }

            return profile;
        }
    }
}