from flask import Flask
from flask_restful import Resource, Api

app = Flask(__name__)
api = Api(app)

class Accounts(Resource):
    def get(self):
        return {
            'accounts':[
                'admin',
                'user',
                'abc',
                'cocc'
            ]
        }
api.add_resource(Accounts,'/')
