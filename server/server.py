#!flask/bin/python
from flask import Flask, jsonify,request
from flask_cors import CORS
from flask_pymongo import PyMongo
from pymongo.collection import ReturnDocument
from bson.objectid import ObjectId
import json
from bson import BSON
from bson import json_util
app = Flask(__name__)


CORS(app)


app.config['MONGO_DBNAME'] = 'opendataTunisia'
app.config['MONGO_URI'] = 'mongodb://localhost:27017/opendataTunisia'
mongo = PyMongo(app)





#***************Define the routes ******************#



@app.route('/')
def index():
    return jsonify({'success':200})





@app.route('/gouverment/<gov_name>', methods=['GET'])
def get_task(gov_name):
    print("ogv name" + gov_name)
    gov_name =gov_name.lower()
    book = mongo.db.data
     #b = book.find_one('$or'[ { 'title': query , "industryIdentifiers.identifier": str(query)}])
    b = book.find_one({'gouv': {'$regex': gov_name}})
    print(b)
    if b:
      output = {'gouv' :b['gouv'] ,'nbre_demaisonsdeculture': b['nbre_demaisonsdeculture'],
                   'nbre_demedecins': b['nbre_demedecins'] , 'nbre_decrimes': b['nbre_decrimes'],
                   'id': str(b['_id']) }
    #output ={}
    else:
      output = "No such name"
    #___return the result_____//
    return jsonify({'result' : output})


if __name__ == '__main__':
    app.run()