<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Online Voting System</title>
    <style type="text/css">
        .center {
            text-align:center;
           
            
        }
        .maindiv {
            margin: auto;
            border-style: solid;
            border-width: 1px;
            width: 800px;
            background-color: #C0C0C0;
            padding: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="maindiv">
        <h1 class="center">
            Online Voting System
        </h1>
        <div class="center">
            <p>Please select one of the candidate and click the "Vote" button.
            </p>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Id"></asp:RadioButtonList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Table]" UpdateCommand="UPDATE [Table] SET Vote = Vote + 1 WHERE (Id = @newvote)">
                <UpdateParameters>
                    <asp:ControlParameter ControlID="RadioButtonList1" Name="newvote" PropertyName="SelectedValue" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Vote" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
        
    </div>
    </form>
</body>
</html>
