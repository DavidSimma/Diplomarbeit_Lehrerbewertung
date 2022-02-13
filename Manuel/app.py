from flask import Flask, request
from flask_mysqldb import MySQL
import string
import random

import json

#Imports from other files
from db import sqlStatements, createStatements, insertStatements,dropTables

#Init FLASK APP
app = Flask(__name__)

#Config für Datenbank
app.config['MYSQL_HOST'] = "localhost"
app.config['MYSQL_USER'] = "root"
app.config['MYSQL_PW'] = ""
app.config['MYSQL_DB'] = "diplomarbeit"

#init mysql datenbank
mysql = MySQL(app)



@app.route("/createTables", methods=["POST"])
def createTabels():
    tables = createStatements.returnAllTables()

    for table in tables:
        sqlStatements.execution(table)
    
    return "TABLES WERE SUCCSESSFULLY CREATED"

@app.route("/getAllTeacherIds", methods=["GET"])
def getAllTeacherIds():
    return sqlStatements.getAllTeacherIds()

@app.route("/insertTeacher", methods=["POST"])
def insertTeacher():
    content = request.json

    teacherId = content['teacherId']

    sqlStatements.execution(insertStatements.insertIntoTeacher(teacherId))

    return "WAS INSERTED"

@app.route("/getAllQuestions", methods=["GET"])
def getAllQuestions():
    return sqlStatements.getAllQuestions() 

@app.route("/insertSelectionQuestion", methods=["POST"])
def insertSelectionQuestion():
    content = request.json

    teacherId = content['teacherId']
    heading = content['heading']
    question1 = content['question1']
    question2 = content['question2']
    question3 = content['question3']
    question4 = content['question4']
    question5 = content['question5']
    question6 = content['question6']
    question7 = content['question7']
    question8 = content['question8']
    annotation = content['annotation']

    sqlStatements.execution(insertStatements.insertIntoSelectionQuestion(teacherId, heading, question1, question2, question3, question4, question5, question6, question7, question8, annotation))

    return "WAS INSERTED"

@app.route("/getAllAnswers", methods=["GET"])
def getAllAnswers():
    return sqlStatements.getAllAnswers()

@app.route("/insertSelectionAnswer", methods=["POST"])
def insertSelectionAnswer():
    content = request.json

    selectionAnswerId = content['selectionAnswerId']
    teacherId = content['teacherId']
    heading = content['heading']
    answer1 = content['answer1']
    answer2 = content['answer2']
    answer3 = content['answer3']
    answer4 = content['answer4']
    answer5 = content['answer5']
    answer6 = content['answer6']
    answer7 = content['answer7']
    answer8 = content['answer8']
    annotation = content['annotation']

    sqlStatements.execution(insertStatements.insertIntoselectionAnswer(selectionAnswerId, teacherId, heading, answer1, answer2, answer3, answer4, answer5, answer6, answer7, answer8, annotation))

    return "WAS INSERTED"   

@app.route("/getFormular", methods=["GET"])
def getFormular():
    return sqlStatements.getFormular()

@app.route("/insertFormular", methods=["POST"])
def insertFormular():
    content = request.json

    formularId = content['formularId']
    teacherId = content['teacherId']
    teacherKey = content['teacherKey']

    sqlStatements.execution(insertStatements.insertIntoFormular(formularId, teacherId, teacherKey))

    return "WAS INSERTED"            

@app.route("/dropTables", methods=["POST"])
def dropAllTables():
    tables = dropTables.returnDropTables()

    for table in tables:
        sqlStatements.execution(table)
    
    return "TABLES WERE SUCCSESSFULLY DELETED"

#getConnection
def getConnection():
    return mysql.connection

if __name__ == "__main__":
    app.run(debug=True)