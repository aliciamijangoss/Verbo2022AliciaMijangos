<html>
    <body>
    <img src="https://www.calculadoraconversor.com/wp-content/uploads/2014/09/teorema-pitagoras.jpg" height="120" width="325" align="left">
        <?php
            $catA = $_GET['catA'];
            $catB = $_GET['catB'];
            $res = sqrt($catB*$catB)+($catA*$catA);

            echo"El valor de la hipotenusa es: ",$res;
        ?>
    </body>
</html>