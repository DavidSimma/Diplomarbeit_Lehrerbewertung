import json

from db.createStatements import returnAllTables

#Grundgerüst von SELECT FUNCTION
def getAllTeacherIds():
    db = getConnectionInClass()
    cur = db.cursor()

    teacherIds = cur.execute("select * from teacher")

    if teacherIds > 0:
        return teacherIds
    else: 
        print("ERROR NO ID FOUND")

def getAllQuestions():
    db = getConnectionInClass()
    cur = db.cursor()
    result = []
    
    allQuestions = cur.execute("select * from selectionQuestion")

    if allQuestions > 0:
        questions = cur.fetchall()
        for question in questions:
            result.append(question)
        
    closeConnections(cur) 
        
    return json.dumps(result)

def getAllAnswers():
    db = getConnectionInClass
    cur = db.cursor()
    result = []

    allAnswers = cur.execute("select * from selectionAnswer")

    if allAnswers > 0:
        answers = cur.fetchall()
        for answer in answers:
            result.append(answer)

    closeConnections(cur) 
        
    return json.dumps(result)

def getFormular():
    db = getConnectionInClass
    cur = db.cursor()
    result = []

    allFormulars = cur.execute("select * from formular")

    if allFormulars > 0:
        formulars = cur.fetchall()
        for formular in formulars:
            result.append(formular)

    closeConnections(cur) 
        
    return json.dumps(result)




#Nur für Inserts, Updates und Delete Functions
def execution(sql):  
    try:
        db = getConnectionInClass()
        cur=db.cursor()
        cur.execute(sql)
        db.commit()
    
    finally:
        closeConnections(cur)
        

def closeConnections(cur):  
    cur.close()


def getConnectionInClass():
    from app import getConnection
    return getConnection()