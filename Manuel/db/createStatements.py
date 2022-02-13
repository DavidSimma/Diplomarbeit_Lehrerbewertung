createTeacher = "Create table if not exists teacher(teacherId varchar(256) unique primary key );"
createFormular = "Create table if not exists formular(formularId int primary key auto_increment, teacherId varchar(256), teacherKey varchar(256));"
createSelectionQuestion = "Create Table if not exists selectionQuestion(teacherId varchar(256) primary key unique, heading varchar(30), question1 varchar(128), question2 varchar(128), question3 varchar(128), question4 varchar(128), question5 varchar(128), question6 varchar(128), question7 varchar(128), question8 varchar(128), annotation varchar(256), foreign key (teacherId) references teacher(teacherId));"
createSelectionAnswer = "Create table if not exists selectionAnswer(selectionAnswerId int primary key auto_increment, teacherId varchar(256), heading varchar(30), answer1 varchar(128), answer2 varchar(128), answer3 varchar(128), answer4 varchar(128), answer5 varchar(128), answer6 varchar(128), answer7 varchar(128), answer8 varchar(128), annotation varchar(256), teacherKey varchar(256), foreign key (teacherId) references teacher(teacherId));"

def returnAllTables():
    tables = []

    tables.append(createTeacher)
    tables.append(createFormular)
    tables.append(createSelectionQuestion)
    tables.append(createSelectionAnswer)

    return tables


def getConnectionInClass():
    from app import getConnection
    return getConnection()