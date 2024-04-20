namespace L02P022021OC651.Pages
{
    public class procesar_formulario
    {
        <?php

$nombre = $_POST['nombre'];
$correo = $_POST['correo'];
$cliente_id = $_POST['cliente_existente'];

header("Location: formulario_creado_exitosamente.php");
exit;
?>
<?php

function obtener_clientes_desde_bd() {

    $clientes = [
        ['id' => 1, 'nombre' => 'Cliente 1'],
        ['id' => 2, 'nombre' => 'Cliente 2'],
        ['id' => 3, 'nombre' => 'Cliente 3'],
    ];
    return $clientes;
}
?>


    }
}
