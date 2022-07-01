<?php
$usuario = $_POST['usuario'];
$pass = $_POST['pass'];

if($usuario === '' || $pass === ''){
    echo json_encode('Llena todos los cambios');
}
else{
    echo json_encode('correcto: <br>Usuario:'.$usuario'<br>Contraseña:'.$pass'');
}

?>