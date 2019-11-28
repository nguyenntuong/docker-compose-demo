<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Demo Web !!!!</title>
</head>
<body>
    <p>Accounts</p>
    <ul>
    <?php
        $content = file_get_contents("http://account-service");
        $json = json_decode($content);
        $accounts = $json->accounts;
        foreach ($accounts as $account) {
                echo("<li>".$account."</li>");
        }
    ?>
    </ul>
    <p>Stocks</p>
    <ul>
    <?php
        $content = file_get_contents("http://stock-service");
        $json = json_decode($content);
        $stocks = $json->stocks;
        foreach ($stocks as $stock) {
                echo("<li>".$stock."</li>");
        }
    ?>
    </ul>
</body>
</html>