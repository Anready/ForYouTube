
# A very simple Flask Hello World app for you to get started with...

from flask import Flask, request, make_response

app = Flask(__name__)

@app.route('/')
def hello_world():
    error_html = """
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ошибка 403 - Доступ запрещен</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f2f2f2;
            text-align: center;
            padding: 50px;
        }

        .error-container {
            background-color: #fff;
            border-radius: 10px;
            padding: 20px;
            box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.2);
            margin: 0 auto;
            max-width: 400px;
        }

        h1 {
            color: #d9534f;
        }

        p {
            color: #333;
        }

        .back-button {
            margin-top: 20px;
            background-color: #d9534f;
            color: #fff;
            padding: 10px 20px;
            text-decoration: none;
            border-radius: 5px;
            font-weight: bold;
        }

        .back-button:hover {
            background-color: #c9302c;
        }
    </style>
</head>
<body>
    <div class="error-container">
        <h1>Ошибка 403 - Доступ запрещен</h1>
        <p>Извините, у вас нет разрешения на доступ к этому сайту.</p>
    </div>
</body>
</html>
"""
    response = make_response(error_html)
    response.status_code = 403
    return response

