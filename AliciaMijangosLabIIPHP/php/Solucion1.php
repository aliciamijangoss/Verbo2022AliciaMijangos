<html>
    <body>
        <?php
            $carnet = $_GET['txt_carnet'];
            $nombre = $_GET['txt_nombre'];
            $apellido = $_GET['txt_carnet'];
            $curso = $_GET['txt_curso'];
            $nota1 = $_GET['txt_nota1'];
            $nota2 = $_GET['txt_nota2'];
            $nota3 = $_GET['txt_nota3'];
            $nota4 = $_GET['txt_nota4'];
            $promedio = ($nota1 + $nota2 + $nota3 + $nota4)/4;

            echo"Carné: ",$carnet;
            echo"<br> Nombre: ",$nombre;
            echo"<br> Apellido: ",$apellido;
            echo"<br> Curso: ",$curso;
        ?>
        <table border="1" width="20%" align="center">
            <tr>
                <td colspan="2">Detalle de Notas</td>
            </tr>
            <tr>
                <td align="center" width="50%">Primera Unidad</td>
                <td align="center"><?php echo $nota1; ?></td>
            </tr>
            <tr>
                <td align="center">Segunda Unidad</td>
                <td align="center"><?php echo $nota2; ?></td>
            </tr>
            <tr>
                <td align="center">Tercera Unidad</td>
                <td align="center"><?php echo $nota3; ?></td>
            </tr>
            <tr>
                <td align="center">Cuarta Unidad</td>
                <td align="center"><?php echo $nota4; ?></td>
            </tr>
            <tr>
                <td align="center">Promedio</td>
                <td align="center"><?php echo $promedio; ?></td>
            </tr>
        </table>
    </body>
</html>