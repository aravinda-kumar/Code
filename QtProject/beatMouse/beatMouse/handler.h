#ifndef HANDLER_H
#define HANDLER_H

#include <QObject>

class handler : public QObject
{
    Q_OBJECT

public:
    static handler *getInstance();
    void addScore();
    void clearScore();

private:
    explicit handler(QObject *parent = nullptr);

signals:
    void beatMouse();
    void scoreToZero();

public slots:

private:
    static handler *hand;
};

#endif // HANDLER_H
