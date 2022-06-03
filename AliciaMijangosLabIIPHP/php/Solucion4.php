<html>
    <body>
        <?php
            $valor = $_GET['valor'];
            if($valor < 0){
                echo"El número es negativo";
            }
            if($valor > 0){
                echo"El número es positivo";
            }
            if($valor == 0){
                echo"El número es neutro";
            }
            else{
                echo"El número no es válido";
            }
        ?>
    <body>
<html>