from flask import Flask
from flask_restful import Resource, Api

app = Flask(__name__)
api = Api(app)

class Product (Resource):
    def get(self):
        return {
            'stocks':[
                'VSmart',
                'BlackBerry',
                'Rice',
                'BMW',
                'BMW2'
            ]
        }

api.add_resource(Product,'/')
