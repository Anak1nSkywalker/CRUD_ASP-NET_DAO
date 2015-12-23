<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="Site.Pages.Detalhes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Detalhes</title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <script src="../Scripts/jquery-1.9.0.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="col-md-offset-1 col-md-10">
                <div class="row">
                    <h3 class="well">Pesquisar Cliente</h3>
                    <br />

                    Informe o Código: 
                    <br />
                    <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" Width="5%" />
                    <br />

                    <asp:Button ID="btnPesquisar" runat="server" Text="Pesquisar" CssClass="btn btn-info btn-lg" OnClick="btnPesquisarCliente" />
                    <a href="../Default.aspx" class="btn btn-default btn-lg">Voltar</a>
                    <br />
                    <br />

                    <p>
                        <asp:Label ID="lblMensagem" runat="server" />
                    </p>

                </div>


                <div class="row">
                    <asp:Panel ID="pnlDados" runat="server">

                        <h3 class="well">Detalhes do Cliente</h3>
                        <br />

                        Nome do Cliente:
                    <br />
                        <asp:TextBox ID="txtNome" runat="server" placeholder="Nome Completo" Width="45%"
                            CssClass="form-control" onClick="btnPesquisarCliente" />
                        <br />

                        Enderaço do Cliente:
                    <br />
                        <asp:TextBox ID="txtEndereco" runat="server" placeholder="Endereço Residencial" Width="50%"
                            CssClass="form-control" />
                        <br />

                        Email do Cliente:
                    <br />
                        <asp:TextBox ID="txtEmail" runat="server" placeholder="Email" Width="25%"
                            CssClass="form-control" />
                        <br />

                        <asp:Button ID="btnAtualizar" runat="server" Text="Atualizar" CssClass="btn btn-warning btn-lg" OnClick="btnAtualizarCliente"/>
                        <asp:Button ID="btnExcluir" runat="server" Text="Excluir" CssClass="btn btn-danger btn-lg" OnClick="btnExcluirCliente" />
                    </asp:Panel>
                </div>
            </div>
        </div>
        <br />
        <br />
    </form>
</body>
</html>
