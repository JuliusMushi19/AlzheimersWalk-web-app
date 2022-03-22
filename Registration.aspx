<%@ Page Title="" Language="C#" MasterPageFile="~/ALZ/MasterPage.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="ALZ.ALZ.Registration" %>

<asp:Content ID="MyContent" ContentPlaceHolderID="MyContentPlaceHolder" runat="server">
    <table width="772" cellspacing="0" cellpadding="0" border="0" align="center">
    <tr>
        <td>

            <table border="0">
                <tr>
                    <td colspan="5"><h2>Registration Form</h2></td>
                </tr>
                <tr>
                    <td width="10"><img src="images/required.gif" /></td>
                    <td width="5">&nbsp;</td>
                    <td>First Name:</td>
                    <td width="5">&nbsp;</td>
                    <td><asp:TextBox ID="txtFirstName" runat="server" Columns="35" MaxLength="50"></asp:TextBox></td>
                </tr>
                <tr>
                    <td width="10"><img src="images/required.gif" /></td>
                    <td width="5">&nbsp;</td>
                    <td>Last Name:</td>
                    <td width="5">&nbsp;</td>
                    <td><asp:TextBox ID="txtLastName" runat="server" Columns="35" MaxLength="50"></asp:TextBox></td>
                </tr>
                   <tr>
                    <td width="10"><img src="images/required.gif" /></td>
                    <td width="5">&nbsp;</td>
                    <td>E-mail Address:</td>
                    <td width="5">&nbsp;</td>
                    <td><asp:TextBox ID="txtEmailAddress" runat="server" Columns="35" MaxLength="50"></asp:TextBox></td>
                </tr>
                <tr>
                    <td width="10">&nbsp;</td>
                    <td width="5">&nbsp;</td>
                    <td>Phone:</td>
                    <td width="5">&nbsp;</td>
                    <td><asp:TextBox ID="txtPhone" runat="server" Columns="35" MaxLength="50"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td width="10">&nbsp;</td>
                    <td width="5">&nbsp;</td>
                    <td>Company Name:</td>
                    <td width="5">&nbsp;</td>
                    <td><asp:TextBox ID="txtCompanyName" runat="server" Columns="35" MaxLength="50"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td width="10">&nbsp;</td>
                    <td width="5">&nbsp;</td>
                    <td>Job Title:</td>
                    <td width="5">&nbsp;</td>
                    <td><asp:TextBox ID="txtJobTitle" runat="server" Columns="35" MaxLength="50"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="5"><h2>Donations</h2></td>
                </tr>
                <tr>
                    <td colspan="5"><asp:RadioButton ID="txt120" runat="server" Text="$120" GroupName="Dollar" /> <asp:RadioButton ID="txt60" runat="server" Text="$60" GroupName="Dollar" /> <asp:RadioButton ID="txt30" runat="server" Text="$30" GroupName="Dollar" /></td>
                </tr>
                <tr>
                    <td colspan="5"><h2>Gender</h2></td>
                </tr>
                 <tr>
                    <td colspan="5"><asp:RadioButton ID="txtMale" runat="server" Text="Male" GroupName="Gender" /> <asp:RadioButton ID="txtFemale" runat="server" Text="Female" GroupName="Gender" /> <asp:RadioButton ID="txtNoAnswerGender" runat="server" Text="I prefer not to answer" GroupName="Gender" /></td>
                </tr>
                 <tr>
                    <td colspan="5"><h2>Race</h2></td>
                </tr>
                 <tr>
                    <td colspan="5"><asp:RadioButton ID="txtBlack" runat="server" Text="African-American/Black" GroupName="Race" /> <asp:RadioButton ID="txtNative" runat="server" Text="American Indian/Alaskan Native" GroupName="Race" /> <asp:RadioButton ID="txtAsian" runat="server" Text="Asian" GroupName="Race" /> <asp:RadioButton ID="txtWhite" runat="server" Text="Caucasian/White" GroupName="Race" /> <asp:RadioButton ID="txtLatino" runat="server" Text="Hispanic/Latino" GroupName="Race" /> <asp:RadioButton ID="txtIslander" runat="server" Text="Native Hawaiian/Other Pacific Islander" GroupName="Race" /> <asp:RadioButton ID="txtMoreRaces" runat="server" Text="Two or more races" GroupName="Race" /> <asp:RadioButton ID="txtOtherRace" runat="server" Text="Other race" GroupName="Race" /> <asp:RadioButton ID="txtNoAnswerRaces" runat="server" Text="I prefer not to answer" GroupName="Race" /></td>
                </tr>
                   <tr>
                    <td colspan="5"><h2>Education</h2></td>
                </tr>
                 <tr>
                    <td colspan="5"><asp:RadioButton ID="txtLessHSDegree" runat="server" Text="Less than high school degree" GroupName="Degree" /> <asp:RadioButton ID="txtHSGraduate" runat="server" Text="High school graduate" GroupName="Degree" /> <asp:RadioButton ID="txtSomeCollege" runat="server" Text="Some college" GroupName="Degree" /> <asp:RadioButton ID="txtBachelor" runat="server" Text="Bachelor degree" GroupName="Degree" /> <asp:RadioButton ID="txtProfessional" runat="server" Text="Post/Professional degree" GroupName="Degree" /> <asp:RadioButton ID="txtNoAnswerEducation" runat="server" Text="I prefer not to answer" GroupName="Degree" /></td>
                </tr>
                   <tr>
                    <td colspan="5"><h2>T-shirt Size</h2></td>
                </tr>
                <tr>
                    <td colspan="5"><asp:RadioButton ID="txtSmall" runat="server" Text="Small" GroupName="TShirt" /> <asp:RadioButton ID="txtLarge" runat="server" Text="Large" GroupName="TShirt" /> <asp:RadioButton ID="txtXLarge" runat="server" Text="X-Large" GroupName="TShirt" /> <asp:RadioButton ID="txtXXLarge" runat="server" Text="XX-Large" GroupName="TShirt" /></td>
                </tr>
                <tr>
                    <td colspan="5">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="5"><asp:Button ID="cmdSubmit" runat="server" Text="Submit Registration" OnClick="cmdSubmit_Click" />&nbsp;&nbsp;&nbsp;<asp:LinkButton ID="cmdCancel" runat="server" OnClick="cmdCancel_Click">Cancel</asp:LinkButton></td>
                </tr>
            </table>

        </td>
    </tr>
</table>
</asp:Content>
