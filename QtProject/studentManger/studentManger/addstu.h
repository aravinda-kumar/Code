#ifndef ADDSTU_H
#define ADDSTU_H

#include <QDialog>
#include <QButtonGroup>

namespace Ui {
class addStu;
}

class addStu : public QDialog
{
    Q_OBJECT

public:
    explicit addStu(QWidget *parent = nullptr);
    ~addStu();
    void ClearUserInterface();

private slots:
    void on_btn_OK_clicked();

    void on_btn_Cancel_clicked();


private:
    Ui::addStu *ui;
    QButtonGroup * insGroup = new QButtonGroup(this);
};

#endif // ADDSTU_H
