namespace L02P022021OC651.Pages.NewFolder
{
    public class usuario
    {
        <!DOCTYPE html>
<html lang = "es" >
< head >
    < meta charset="UTF-8">
    <meta name = "viewport" content="width=device-width, initial-scale=1.0">
    <title>Formulario de Creación de Usuarios</title>
</head>
<body>
    <h2>Formulario de Creación de Usuarios</h2>
    <form action = "procesar_formulario.php" method="POST">
        <label for="nombre">Nombre:</label>
        <input type = "text" id="nombre" name="nombre" required><br><br>
        
        <label for="correo">Correo electrónico:</label>
        <input type = "email" id="correo" name="correo" required><br><br>
        
        <label for="cliente_existente">Cliente existente:</label>
        <select id = "cliente_existente" name="cliente_existente">
            <?php

            $clientes = obtener_clientes_desde_bd();
            foreach ($clientes as $cliente) {
                echo "<option value='" . $cliente['id'] . "'>" . $cliente['nombre'] . "</option>";
            }
            ?>
        </select><br><br>
        
        <input type = "submit" value="Crear Usuario">
    </form>
</body>
</html>
<!DOCTYPE html>
<html lang = "es" >
< head >
    < meta charset="UTF-8">
    <meta name = "viewport" content="width=device-width, initial-scale=1.0">
    <title>Formulario de Creación de Usuarios</title>
</head>
<body>
    <h2>Formulario de Creación de Usuarios</h2>
    <form action = "procesar_formulario.php" method="POST">
        <label for="nombre">Nombre:</label>
        <input type = "text" id="nombre" name="nombre" required><br><br>
        
        <label for="correo">Correo electrónico:</label>
        <input type = "email" id="correo" name="correo" required><br><br>
        
        <label for="cliente_existente">Cliente existente:</label>
        <select id = "cliente_existente" name="cliente_existente">
            <? php

            $clientes = obtener_clientes_desde_bd();
            foreach ($clientes as $cliente) {
                echo "<option value='" . $cliente['id'] . "'>" . $cliente['nombre'] . "</option>";
            }
            ?>
        </select><br><br>
        
        <input type="submit" value="Crear Usuario">
    </form>
</body>
</html>

    }
}
