#ifndef MYITEM_H
#define MYITEM_H

#include<QGraphicsPixmapItem>
#include <QPixmap>
#include <QString>
#include <stdlib.h>
#include <QGraphicsSceneMouseEvent>
#include "handler.h"
#include <QCursor>

class myitem : public QGraphicsPixmapItem
{
public:
    myitem();
    void setPic(QString path);

    void mousePressEvent(QGraphicsSceneMouseEvent *event);

    void mouseReleaseEvent(QGraphicsSceneMouseEvent *event);


    void SetMouse(bool mouse);
    bool IsMouse();

    void SetStart(bool start);
    bool IsStart();
private:
    bool mouse;
    bool start;

};

#endif // MYITEM_H
