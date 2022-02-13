drop_formular = "DROP TABLE IF EXISTS formular"
drop_selectionAnswer = "DROP TABLE IF EXISTS selectionAnswer"
drop_selectionQuestion = "DROP TABLE IF EXISTS selectionQuestion"
drop_teacher = "DROP TABLE IF EXISTS teacher"

def returnDropTables():
    dropTables = []
    dropTables.append(drop_formular)
    dropTables.append(drop_selectionAnswer)
    dropTables.append(drop_selectionQuestion)
    dropTables.append(drop_teacher)

    return dropTables