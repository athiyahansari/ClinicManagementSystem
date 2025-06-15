using CMS.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.View.Admin
{
    public partial class adminbookappointment : Form
    {
        public adminbookappointment()
        {
            InitializeComponent();
            this.Load += adminbookappointment_Load;
        }

        private void dataGridAdminPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string columnName = dataGridAdminPatient.Columns[e.ColumnIndex].Name;
                int appointmentId = Convert.ToInt32(dataGridAdminPatient.Rows[e.RowIndex].Cells["AppointmentIDcolumn"].Value);

                var controller = new AdminPatientController();

                if (columnName == "ResheduleColumn")
                {
                    using (var dialog = new RescheduleDialog())
                    {
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            DateTime newDate = dialog.SelectedDate;
                            TimeSpan newTime = dialog.SelectedTime;

                            if (controller.RescheduleAppointment(appointmentId, newDate, newTime))
                            {
                                MessageBox.Show("Appointment rescheduled successfully.");
                                LoadAppointments();
                            }
                            else
                            {
                                MessageBox.Show("Failed to reschedule the appointment.");
                            }
                        }
                    }
                }
                else if (columnName == "CancelColumn")
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to cancel this appointment?", "Confirm Cancel", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        if (controller.CancelAppointment(appointmentId))
                        {
                            MessageBox.Show("Appointment status updated to 'Cancelled'.");
                            LoadAppointments();
                        }
                    }
                }
            }
        }

        private void LoadAppointments()
        {
            AdminPatientController controller = new AdminPatientController();
            var appointmentList = controller.GetAllAppointments();

            dataGridAdminPatient.Rows.Clear();

            foreach (var appt in appointmentList)
            {
                dataGridAdminPatient.Rows.Add(
                     appt.AppointmentID,
                     appt.PatientName,
                     appt.DoctorName,
                     appt.Date.ToString("yyyy-MM-dd"),
                     appt.Time,
                     appt.Status
                );
            }
        }

        private void adminbookappointment_Load(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        // Inline reschedule dialog using DateTimePicker and ComboBox
        private class RescheduleDialog : Form
        {
            public DateTime SelectedDate { get; private set; }
            public TimeSpan SelectedTime { get; private set; }

            private DateTimePicker datePicker;
            private ComboBox comboTime;
            private Button btnOK, btnCancel;

            public RescheduleDialog()
            {
                this.Text = "Reschedule Appointment";
                this.Size = new Size(400, 280);
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
                this.StartPosition = FormStartPosition.CenterParent;
                this.MaximizeBox = false;
                this.MinimizeBox = false;

                //Date Picker
                Label lblDate = new Label() { Text = "Select Date:", Location = new Point(15, 20), AutoSize = true };
                datePicker = new DateTimePicker()
                {
                    Location = new Point(125, 15),
                    Format = DateTimePickerFormat.Short,
                    Width = 200
                };

                // Time slot dropdown
                Label lblTime = new Label() { Text = "Select Time:", Location = new Point(15, 70), AutoSize = true };
                comboTime = new ComboBox()
                {
                    Location = new Point(125, 65),
                    Width = 200,
                    DropDownStyle = ComboBoxStyle.DropDownList
                };
                comboTime.Items.AddRange(new string[] { "10:00", "11:00", "12:00", "13:00", "15:00", "16:00" });
                comboTime.SelectedIndex = 0;

                // OK/Cancel buttons
                btnOK = new Button() { Text = "OK", Location = new Point(45, 150), Width = 150 };
                btnOK.Click += BtnOK_Click;
                btnCancel = new Button() { Text = "Cancel", Location = new Point(200, 150), Width = 150, DialogResult = DialogResult.Cancel };

                // Add controls
                this.Controls.Add(lblDate);
                this.Controls.Add(datePicker);
                this.Controls.Add(lblTime);
                this.Controls.Add(comboTime);
                this.Controls.Add(btnOK);
                this.Controls.Add(btnCancel);
            }

            private void BtnOK_Click(object sender, EventArgs e)
            {
                // Assign selected values
                SelectedDate = datePicker.Value.Date;
                SelectedTime = TimeSpan.Parse(comboTime.SelectedItem.ToString());
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        private void navdoc_Click(object sender, EventArgs e)
        {
            ManageDoctors manageDoctor = new ManageDoctors();
            manageDoctor.Show();
            this.Hide();

        }

        private void navpatient_Click(object sender, EventArgs e)
        {
            Manage_Patient manage_Patient = new Manage_Patient();
            manage_Patient.Show();
            this.Hide();
        }

        private void navreports_Click(object sender, EventArgs e)
        {
            Reportadmin reportAdmin = new Reportadmin();
            reportAdmin.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(); 
            loginForm.Show();
            this.Hide(); // Hide the current form
        }
    }
}

