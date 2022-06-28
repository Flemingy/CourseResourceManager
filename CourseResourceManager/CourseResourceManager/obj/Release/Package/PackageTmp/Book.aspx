<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Book.aspx.cs" Inherits="CourseResourceManager.Book" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>书单</title>
    <link href="~/css/book.css" rel="stylesheet" type="text/css" />

    <style>
        div {
            text-align: center;
        }

        body {
            background-image: url("/img/plane.jpg");
        }
    </style>
</head>
<body>

    <div class="booklist">
        <div class="section">
            <br />
            <br />
            <h4>正在读的书</h4>
            <ul class="clearfix">
                <a href="https://cowtransfer.com/s/3ac65cc2c49d4c">图解TCP IP（第5版）</a><br />
                <a href="https://cowtransfer.com/s/04dbeb6da7cd48">redis设计与实现(第2版)</a><br />
                <a href="https://cowtransfer.com/s/287fe5ebe1a34f">nginx高性能web服务器详解</a><br />
            </ul>
        </div>
        <div class="section">
            <br />
            <br />
            <br />
            <h4>已读的书</h4>
            <ul class="clearfix">
                <a href="https://cowtransfer.com/s/775a0613191441">操作系统设计与实现</a><br />
                <a href="https://cowtransfer.com/s/d499d01742e247">计算机网络-自顶向下方法（第6版）</a><br />
                <a href="https://cowtransfer.com/s/f440285349254e">linux环境编程：从应用到内核 (linux-unix技术)</a>
        </div>
    </div>

    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
