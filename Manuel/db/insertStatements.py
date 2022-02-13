#Hier kommen alle Inserts rein

def insertIntoTeacher(teacherId):
    return "insert into teacher(teacherId) values (%s)"%(teacherId)

def insertIntoFormular(formularId, teacherId, teacherKey):
    return "insert into formular(formularId, teacherId, teacherKey) values (%s,%s,%s)"%(formularId, "'"+teacherId+"'", "'"+teacherKey+"'")

def insertIntoSelectionQuestion(teacherId, heading, question1, question2, question3, question4, question5, question6, question7, question8, annotation):
    return "insert into selectionQuestion(teacherId, heading, question1, question2, question3, question4, question5, question6, question7, question8, annotation) values(%s,%s,%s,%s,%s,%s,%s,%s,%s,%s,%s)"%(teacherId, "'"+heading+"'", "'"+question1+"'", "'"+question2+"'", "'"+question3+"'", "'"+question4+"'", "'"+question5+"'", "'"+question6+"'", "'"+question7+"'", "'"+question8+"'", "'"+annotation+"'")

def insertIntoselectionAnswer(selectionAnswerId, teacherId, heading, answer1, answer2, answer3, answer4, answer5, answer6, answer7, answer8, annotation):
    return "insert into selectionAnswer(selectionAnswerId, teacherId, heading, answer1, answer2, answer3, answer4, answer5, answer6, answer7, answer8, annotation) values(%s,%s,%s,%s,%s,%s,%s,%s,%s,%s,%s,%s)"%(selectionAnswerId, teacherId, "'"+heading+"'", "'"+answer1+"'", "'"+answer2+"'", "'"+answer3+"'", "'"+answer4+"'", "'"+answer5+"'", "'"+answer6+"'", "'"+answer7+"'", "'"+answer8+"'", "'"+annotation+"'")

def getConnectionInClass():
    from app import getConnection
    return getConnection()