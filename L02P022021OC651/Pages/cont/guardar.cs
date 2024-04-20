namespace L02P022021OC651.Pages.cont
{
    public class guardar
    {
        <form id = "formulario_usuario" >
    < !--Resto de campos del formulario -->
    <input type = "button" value="Guardar" onclick="guardarUsuario()">
</form>

            <script>
function guardarUsuario()
        {
            var nombre = document.getElementById('nombre').value;
            var correo = document.getElementById('correo').value;
            var clienteExistente = document.getElementById('cliente_existente').value;


            var xhr = new XMLHttpRequest();
            xhr.open('POST', 'guardar_usuario.php', true);
            xhr.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');
            xhr.onreadystatechange = function() {
                if (xhr.readyState === 4 && xhr.status === 200)
                {

                    refrescarListadoClientes();
                }
            };
            xhr.send('nombre=' + nombre + '&correo=' + correo + '&cliente_existente=' + clienteExistente);
        }

        function refrescarListadoClientes()
        {

            var xhr = new XMLHttpRequest();
            xhr.open('GET', 'obtener_clientes.php', true);
            xhr.onreadystatechange = function() {
                if (xhr.readyState === 4 && xhr.status === 200)
                {

                    document.getElementById('clientes_existente').innerHTML = xhr.responseText;
                }
            };
            xhr.send();
        }
</script>



    }
}
