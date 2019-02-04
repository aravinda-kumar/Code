#include "myitem.h"
#include <QDebug>

myitem::myitem()
{
    this->setPixmap(QPixmap(":/bg/pic/bg1.png"));
    this->start = false;
    this->mouse = false;

    this->setCursor(QCursor(QPixmap(":/mouse/pic/pictureUp")));
}

void myitem::setPic(QString path)
{
    this->setPixmap(QPixmap(path));
}

void myitem::mousePressEvent(QGraphicsSceneMouseEvent *event)
{
    this->setCursor(QCursor(QPixmap(":/mouse/pic/picturedown")));
    if(this->IsStart())
    {
        if(this->mouse)
        {
            handler *hand = handler::getInstance();
            hand->addScore();
            this->setPixmap(QPixmap(":/mouse/pic/beatmouse"));
            this->SetMouse(false);
//            qDebug() << "打的是老鼠";
        }
        else
        {
//            qDebug() << "打的不是老鼠";
        }
    }
}

void myitem::mouseReleaseEvent(QGraphicsSceneMouseEvent *event)
{
    this->setCursor(QCursor(QPixmap(":/mouse/pic/pictureUp")));
}

void myitem::SetMouse(bool mouse)
{
    this->mouse = mouse;
}

bool myitem::IsMouse()
{
    return  this->mouse;
}

void myitem::SetStart(bool start)
{
    this->start = start;
}

bool myitem::IsStart()
{
    return this->start;
}
