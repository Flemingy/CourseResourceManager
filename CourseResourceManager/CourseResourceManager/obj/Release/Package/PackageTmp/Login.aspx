<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CourseResourceManager.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>登陆</title>
    <style>
        form {
            color: #000000;
            width: 482px;
            font-size: 20px;
            margin-top: 220px;
            margin-left: auto;
            margin-right: auto;
            margin-bottom: auto;
        }

        #spanpsd {
            margin-left: 125px;
        }

        #spanuser {
            margin-left: 110px;
        }

        div {
            margin: 30px auto;
            align-content: center;
        }

        .textbox {
            border-radius: 5px;
        }

        .text {
            font-size: medium;
            text-align: center;
        }

        #LinkButton1 {
            text-decoration: none;
            color: black;
            margin-left: 220px;
            font-size: small;
            text-decoration: underline;
        }

        #Button1 {
            border-radius: 2px;
            border: solid 1px;
            background-color: darkolivegreen;
            margin-left: 150px;
            margin-top: 10px;
            border-style: dashed;
        }

        .form {
            border-radius: 50px;
            background: #e0e0e0;
            box-shadow: 20px 20px 32px #989898,-20px -20px 32px #ffffff;
        }

        body {
            background-image: url("/img/flower.jpg");
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                &nbsp; <span id="spanuser">账号:</span>  &nbsp; 
                <asp:TextBox ID="TextBox1" runat="server" CssClass="textbox" Height="30px" Width="240px"></asp:TextBox>
            </div>

            <div>
                <span id="spanpsd">密码:</span> &nbsp;
                <asp:TextBox ID="TextBox2" runat="server" CssClass="textbox" Height="30px" Width="240px" TextMode="Password" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
            </div>

            <div>
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">还没有账号？马上注册</asp:LinkButton>
                <br />
                <asp:Button ID="Button1" runat="server" Text="登 录" Width="270px" Height="40px" OnClick="Button1_Click" />
                <asp:Label ID="Label4" runat="server" Text="  "></asp:Label>
                <p>
                    &nbsp;
                </p>
            </div>
        </div>

        <asp:Label ID="Label2" runat="server" Text="  "></asp:Label>
        <asp:Label ID="Label3" runat="server" Text="   "></asp:Label>

    </form>
</body>
</html>
