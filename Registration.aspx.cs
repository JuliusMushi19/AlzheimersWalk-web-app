using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ALZ.ALZ
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtFirstName.Focus();
            }
        }

        private void ShowMessage(String MessageToDisplay)
        {
            // define the name and type of the client script
            String csName = "PopupScript";
            Type csType = this.GetType();

            // get a ClientScriptManager object
            System.Web.UI.ClientScriptManager cs = Page.ClientScript;

            // check to see if the startup script is already registered
            if (!cs.IsStartupScriptRegistered(csType, csName))
            {
                String csText = "alert('" + MessageToDisplay + "');";
                cs.RegisterStartupScript(csType, csName, csText, true);
            }
        }

        private Boolean VerifyForm()
        {
            if (txtFirstName.Text == "")
            {
                ShowMessage("Please provide your first name.");
                txtFirstName.Focus();
                return false;
            }
            else if (txtLastName.Text == String.Empty)
            {
                ShowMessage("Please provide your last name.");
                txtLastName.Focus();
                return false;
            }
            else if (txtEmailAddress.Text == String.Empty)
            {
                ShowMessage("Please provide your e-mail address.");
                txtEmailAddress.Focus();
                return false;
            }
            else if (txt120.Checked == false && txt60.Checked == false && txt30.Checked == false)
            {
                ShowMessage("Please select a donation.");
                txt120.Focus();
                return false;
            }
            else if (txtMale.Checked == false && txtFemale.Checked == false && txtNoAnswerGender.Checked == false)
            {
                ShowMessage("Please select a gender.");
                txtMale.Focus();
                return false;
            }
            else if (txtBlack.Checked == false && txtNative.Checked == false && txtAsian.Checked == false && txtWhite.Checked == false && txtLatino.Checked == false && txtIslander.Checked == false && txtMoreRaces.Checked == false && txtOtherRace.Checked == false && txtNoAnswerRaces.Checked == false)
            {
                ShowMessage("Please select a race.");
                txtBlack.Focus();
                return false;
            }
            else if (txtLessHSDegree.Checked == false && txtHSGraduate.Checked == false && txtSomeCollege.Checked == false && txtBachelor.Checked == false && txtProfessional.Checked == false)
            {
                ShowMessage("Please select an education.");
                txtLessHSDegree.Focus();
                return false;
            }
            else if (txtSmall.Checked == false && txtLarge.Checked == false && txtXLarge.Checked == false & txtXXLarge.Checked == false)
            {
                ShowMessage("Please select a t-shirt size.");
                txtSmall.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        protected Boolean AddRegistration()
        {
            try
            {
                // setup and create the connection to the database
                ADODB.Connection objConnect = new ADODB.Connection();
                ADODB.Recordset objRS = new ADODB.Recordset();

                String strConnection = "Data Source=csis-sql.elmhurst.edu;Initial Catalog=MIT543-ERM-Symposium-Mushi;User ID=cs550;Password=Elmhurst1871;Provider=msoledbsql;";
                String SQL = "SELECT * FROM [ALZ_Registrations];";

                // open the connection
                objConnect.Open(strConnection);
                objRS.Open(SQL, objConnect, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic);

                // add registration record
                objRS.AddNew();

                objRS.Fields["RegistrationID"].Value = Guid.NewGuid().ToString();

                objRS.Fields["FirstName"].Value = txtFirstName.Text;
                objRS.Fields["LastName"].Value = txtLastName.Text;
                objRS.Fields["EmailAddress"].Value = txtEmailAddress.Text;


                if (txtPhone.Text != String.Empty)
                {
                    objRS.Fields["Phone"].Value = txtPhone.Text;
                }
                else
                {
                    objRS.Fields["Phone"].Value = String.Empty;
                }

                if (txtCompanyName.Text != String.Empty)
                {
                    objRS.Fields["CompanyName"].Value = txtCompanyName.Text;
                }
                else
                {
                    objRS.Fields["CompanyName"].Value = String.Empty;
                }

                if (txtJobTitle.Text != String.Empty)
                {
                    objRS.Fields["JobTitle"].Value = txtJobTitle.Text;
                }
                else
                {
                    objRS.Fields["JobTitle"].Value = String.Empty;
                }

                if (txt120.Checked == true)
                {
                    objRS.Fields["Donation"].Value = "$120";
                }
                else if (txt60.Checked == true)
                {
                    objRS.Fields["Donation"].Value = "$60";
                }
                else if (txt30.Checked == true)
                {
                    objRS.Fields["Donation"].Value = "$30";
                }

                if (txtMale.Checked == true)
                {
                    objRS.Fields["Gender"].Value = "Male";
                }
                else if (txtFemale.Checked == true)
                {
                    objRS.Fields["Gender"].Value = "Female";
                }
                else if (txtNoAnswerGender.Checked == true)
                {
                    objRS.Fields["Gender"].Value = "I prefer not to answer";
                }


                if (txtBlack.Checked == true)
                {
                    objRS.Fields["Race"].Value = "African-American/Black";
                }
                else if (txtNative.Checked == true)
                {
                    objRS.Fields["Race"].Value = "American Indian/Alaskan Native";
                }
                else if (txtAsian.Checked == true)
                {
                    objRS.Fields["Race"].Value = "Asian";
                }
                else if (txtWhite.Checked == true)
                {
                    objRS.Fields["Race"].Value = "Caucasian/White";
                }
                else if (txtLatino.Checked == true)
                {
                    objRS.Fields["Race"].Value = "Hispanic/Latino";
                }
                else if (txtIslander.Checked == true)
                {
                    objRS.Fields["Race"].Value = "Native Hawaiian/Other Pacific Islander";
                }
                else if (txtMoreRaces.Checked == true)
                {
                    objRS.Fields["Race"].Value = "Two or more races";
                }
                else if (txtNoAnswerRaces.Checked == true)
                {
                    objRS.Fields["Race"].Value = "I prefer not to answer";
                }

                if (txtLessHSDegree.Checked == true)
                {
                    objRS.Fields["Education"].Value = "Less than high school degree";
                }
                else if (txtHSGraduate.Checked == true)
                {
                    objRS.Fields["Education"].Value = "High school graduate";
                }
                else if (txtSomeCollege.Checked == true)
                {
                    objRS.Fields["Education"].Value = "Some college";
                }
                else if (txtBachelor.Checked == true)
                {
                    objRS.Fields["Education"].Value = "Bachelor degree";
                }
                else if (txtProfessional.Checked == true)
                {
                    objRS.Fields["Education"].Value = "Post/Professional";
                }
                else if (txtNoAnswerEducation.Checked == true)
                {
                    objRS.Fields["Education"].Value = "I prefer not to answer";
                }


                if (txtSmall.Checked == true)
                {
                    objRS.Fields["TshirtSize"].Value = "Small";
                }
                else if (txtLarge.Checked == true)
                {
                    objRS.Fields["TshirtSize"].Value = "Large";
                }
                else if (txtXLarge.Checked == true)
                {
                    objRS.Fields["TshirtSize"].Value = "X-Large";
                }
                else if (txtXXLarge.Checked == true)
                {
                    objRS.Fields["TshirtSize"].Value = "XX-Large";
                }

                objRS.Fields["IsDeleted"].Value = 0;


                // create a datetime stamp
                objRS.Fields["DateTimeCreated"].Value = DateTime.Now;

                // save the record to the database
                objRS.Update();

                // close the connection to the database
                objRS.Close();
                objConnect.Close();

                // destroy the objects
                objRS = null;
                objConnect = null;

                return true;
            }
            catch (Exception)
            {
                // throw;
                return false;
            }
        }


        protected void cmdSubmit_Click(object sender, EventArgs e)
        {
            if (VerifyForm() == true)
            {
                    if (AddRegistration() == true)
                    {
                        // redirect to the thank you page
                        Response.Redirect("ThankYou.aspx");
                    }
                    else
                    {
                        // redirect to the error page
                        Response.Redirect("Error.aspx");
                    }
               
            }

        }

        protected void cmdCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://act.alz.org/");
        }
    }
}