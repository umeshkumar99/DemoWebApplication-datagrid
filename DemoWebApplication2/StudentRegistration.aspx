﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentRegistration.aspx.cs" Inherits="DemoWebApplication2.StudentRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        .errormsg
        {
            color:red;
            font-weight:bold;
        }
    </style>
    <title></title>
</head>
<body style="background-color:aquamarine;">
    <form id="form1" runat="server">
   <div style="top:0;width:100%;height:60px;background-color:chocolate;z-index:1;position:sticky;margin-top:-5"></div>
         <div style="margin-left:300px;margin-top:150px;">
    

        <table border="1"><tr><td colspan="2" style="text-align:center;background-color:cadetblue;font-weight:bold;font-size:20px;">Student Registration form</td></tr>
            <tr>
                <td>
<table border="1" style="width:500px;text-align:center;background-color:burlywood">
    <tr><td>StudentCode</td>
       
        <td> <asp:TextBox ID="txtcode" runat="server" TabIndex="1"></asp:TextBox>

            <asp:RequiredFieldValidator CssClass="errormsg" ID="RequiredFieldValidator1" ControlToValidate="txtcode" runat="server" ErrorMessage="Student Code is required"></asp:RequiredFieldValidator>
        </td></tr>
    <tr><td>StudentName</td>
        
        <td><asp:TextBox ID="txtname" runat="server" TabIndex="2"></asp:TextBox>
            <asp:RequiredFieldValidator  CssClass="errormsg" ID="RequiredFieldValidator2" ControlToValidate="txtname" runat="server" ErrorMessage="Student name is required"></asp:RequiredFieldValidator>

        </td></tr>
    <tr><td>StudentCourse</td>
        
        <td><asp:TextBox ID="txtCourse" runat="server" TabIndex="3" ></asp:TextBox>
            <asp:RequiredFieldValidator CssClass="errormsg" ID="RequiredFieldValidator3" ControlToValidate="txtCourse" runat="server" ErrorMessage="Student Course is required"></asp:RequiredFieldValidator>

        </td></tr>

    <tr><td>Fees</td>
        
        <td><asp:TextBox ID="txtfees" runat="server" TabIndex="4" TextMode="Number"></asp:TextBox>
            <asp:RangeValidator CssClass="errormsg" ID="RangeValidator1" runat="server" MaximumValue="50000" MinimumValue="5000" ControlToValidate="txtfees" ErrorMessage="Fees should be between 5000 -50000"></asp:RangeValidator>
        </td></tr>

    <tr><td>Photo</td>
        <td>    <asp:FileUpload ID="FileUpload1" runat="server" TabIndex="5" />
            
        <br />
        <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click" TabIndex="6" />
        <br />

</td></tr>
    <tr><td colspan="2" style="text-align:center">
        <asp:Button ID="btnSave" runat="server" Text="Save Data"  TabIndex="7" OnClick="btnSave_Click" />

        </td></tr>
    <tr><td>


        <asp:TextBox ID="txtphoto" runat="server" ViewStateMode="Enabled" Visible="false"></asp:TextBox>
        </td></tr>

</table>

                </td>
               
                
                 <td>
                    <asp:Image ID="imgDemo" runat="server" Width="200" Height="200" />
                </td>


            </tr>

        </table>

             <table>
                 <tr><td>Studedent Details</td></tr>
                 <tr><td>
                     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"  AllowSorting="True"
                      AutoGenerateDeleteButton="True" AutoGenerateEditButton="false" AutoGenerateSelectButton="True"   
                     ShowFooter="True" OnRowCommand="GridView1_RowCommand" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" 
                                         
                     >
                    
                <Columns>
                     <asp:TemplateField HeaderText="Sno" Visible="False">
                                                            <ItemTemplate>
                                                            <asp:Label ID="lblId" runat="server" Text='<%# Eval("sno") %>'></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>

                  <asp:BoundField DataField="sno" HeaderText="sno" ReadOnly="True" SortExpression="sno" />
                    <asp:ButtonField ButtonType="Button" CommandName="Edit" ShowHeader="True" Text="Edit" />
                                                         <asp:TemplateField ShowHeader="False">
                                                             <ItemTemplate>
                                                                 <asp:Button ID="btnDelete" runat="server" OnClientClick="return confirm('Are you sure you want to Delete?');" 
                                                                     CausesValidation="false" CommandName="Del" CommandArgument='<%# ((GridViewRow)Container).RowIndex %>' Text="Delete" />
                                                             </ItemTemplate>
                                                        </asp:TemplateField>
                    <asp:TemplateField HeaderText="Student Name" Visible="true">
                                                            <ItemTemplate>
                                                            <asp:Label ID="lblsname" runat="server" Text='<%# Eval("sname") %>'></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>  
                   <%-- <asp:BoundField DataField="sname" HeaderText="Student name" SortExpression="sname" />--%>
                     <asp:TemplateField HeaderText="course" Visible="true">
                                                            <ItemTemplate>
                                                            <asp:Label ID="lblcourse" runat="server" Text='<%# Eval("course") %>'></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>  
                  <%--  <asp:BoundField DataField="course" HeaderText="course" SortExpression="course" />--%>

                    <asp:TemplateField HeaderText="fee" Visible="true">
                                                            <ItemTemplate>
                                                            <asp:Label ID="lblfee" runat="server" Text='<%# Eval("fee") %>'></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>  


                    <%--<asp:BoundField DataField="fee" HeaderText="fee" SortExpression="fee" />--%>
                    
                    
                    <asp:TemplateField>
                         <ItemTemplate>
                            
                       <asp:Image ID="imgPhoto" runat="server" ImageUrl="<%#Bind('Photo1')%>" Width="100" Height="100"/>
                                      
                        
                        </ItemTemplate>
                        </asp:TemplateField>
               
                                    </Columns>
                     
                   
                     
                </asp:GridView>

                     </td></tr>
             </table>
    </div>
    </form>
</body>
</html>
