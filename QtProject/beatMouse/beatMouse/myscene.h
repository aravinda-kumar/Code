#ifndef MYSCENE_H
#define MYSCENE_H

#include <QObject>
#include <QGraphicsScene>
#include "myitem.h"
#include <QTimer>

class myScene : public QGraphicsScene
{
    Q_OBJECT
public:
    explicit myScene(QObject *parent = nullptr);

signals:

public slots:
    void showMouse();
    void StartGame();
    void PauseGame();
    void StopGame();

private:
    myitem *item[16];
    QTimer *ptimer;
};
#endif // MYSCENE_H
