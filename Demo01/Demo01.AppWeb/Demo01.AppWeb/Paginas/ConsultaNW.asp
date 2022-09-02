<DOCTYPE html>
<html xmlns="http://www.w3.org/199/xhtml">
    <head>

<link href="../Estilos/SCORD.css" rel="stylesheet" />
    </head>
    <body>
        <form ID="form1" runat="server">
    <div>
    <div class ="Titulo"> Demo 01:Arquitectura N Capas N Comexiones N Comandos N Cursores </div>
    <div class="Subtitulo"> Lista de Empleados</div>
        <div>
            <asp:GridView ID="gvEmpleado" runat="server">
                <HeaderStyle cssclass="FilaCabecera"/>
                <RowStyle cssclass="FilaDatos" />
            </asp:GridView>

        </div>
    </div>
    </form>
</body>
</html>