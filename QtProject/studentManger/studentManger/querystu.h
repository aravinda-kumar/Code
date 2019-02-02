#ifndef QUERYSTU_H
#define QUERYSTU_H

#include <QDialog>
#include <QFile>
#include <QIODevice>
#include <QList>
#include <QString>
#include <QTextStream>
#include <QMessageBox>
#include <QDebug>
#include <QTimer>
#include <QStringList>
#include <QStandardItem>
#include <QStandardItemModel>

namespace Ui {
class queryStu;
}

class queryStu : public QDialog
{
    Q_OBJECT

public:
    explicit queryStu(QWidget *parent = nullptr);
    ~queryStu();

private slots:
    void on_btnSearch_clicked();

    void on_btnClear_clicked();

private:
    Ui::queryStu *ui;
    int readFromFile();
    QList<QString> stuLines;
    void doQuery(int index, QString cnt);
    QStandardItemModel *model;
    void Display(int row, QStringList subs);
    int row =0;
    void SetTableHeader();
};

#endif // QUERYSTU_H
