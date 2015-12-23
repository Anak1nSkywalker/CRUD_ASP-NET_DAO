<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Site.Pages.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastro</title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <script src="../Scripts/jquery-1.9.0.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="col-md-offset-1 col-md-10">
            <div class="row">
                <h3 class="well">Cadastro de Cliente</h3>
                <br />

                Nome do Cliente: <br />
                <asp:TextBox ID="txtNome" runat="server" placeholder="Nome Completo" Width="45%" 
                    CssClass="form-control" />
                <asp:RequiredFieldValidator 
                    ID="RequiredNome" 
                    runat="server" 
                    ControlToValidate="txtNome" 
                    ErrorMessage="Por favor digite o seu nome." 
                    ForeColor="red" />
                <br />
                <br />

                Enderaço do Cliente: <br />
                <asp:TextBox ID="txtEndereco" runat="server" placeholder="Endereço Residencial" Width="50%" 
                    CssClass="form-control" />
                <asp:RequiredFieldValidator 
                    ID="RequiredEndereco" 
                    runat="server" 
                    ControlToValidate="txtEndereco" 
                    ErrorMessage="Por favor digite o seu endereço." 
                    ForeColor="red" />
                <br />
                <br />

                Email do Cliente: <br />
                <asp:TextBox ID="txtEmail" runat="server" placeholder="Email" Width="25%" 
                    CssClass="form-control" />
                <asp:RequiredFieldValidator 
                    ID="RequiredEmail" 
                    runat="server" 
                    ControlToValidate="txtEmail" 
                    ErrorMessage="Por favor digite o seu email." 
                    ForeColor="red" />
                <br />
                <br />

                <p>
                    <asp:Label ID="lblMensagem" runat="server" />                                      
                </p>

                <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" CssClass="btn btn-success btn-lg" OnClick="btnCadastrarCliente" />
                <a href="../Default.aspx" class="btn btn-default btn-lg">Voltar</a>

            </div>            
        </div>
    </div>
    </form>
</body>
</html>
