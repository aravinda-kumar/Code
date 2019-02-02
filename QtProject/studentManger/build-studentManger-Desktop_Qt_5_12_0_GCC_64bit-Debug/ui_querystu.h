/********************************************************************************
** Form generated from reading UI file 'querystu.ui'
**
** Created by: Qt User Interface Compiler version 5.12.0
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_QUERYSTU_H
#define UI_QUERYSTU_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QComboBox>
#include <QtWidgets/QDialog>
#include <QtWidgets/QHBoxLayout>
#include <QtWidgets/QHeaderView>
#include <QtWidgets/QLineEdit>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QTableView>
#include <QtWidgets/QVBoxLayout>

QT_BEGIN_NAMESPACE

class Ui_queryStu
{
public:
    QVBoxLayout *verticalLayout_2;
    QVBoxLayout *verticalLayout;
    QHBoxLayout *horizontalLayout;
    QComboBox *cbbMethod;
    QLineEdit *leCnt;
    QPushButton *btnSearch;
    QPushButton *btnClear;
    QTableView *tableView;

    void setupUi(QDialog *queryStu)
    {
        if (queryStu->objectName().isEmpty())
            queryStu->setObjectName(QString::fromUtf8("queryStu"));
        queryStu->resize(900, 500);
        queryStu->setMinimumSize(QSize(900, 500));
        queryStu->setMaximumSize(QSize(900, 500));
        verticalLayout_2 = new QVBoxLayout(queryStu);
        verticalLayout_2->setObjectName(QString::fromUtf8("verticalLayout_2"));
        verticalLayout = new QVBoxLayout();
        verticalLayout->setObjectName(QString::fromUtf8("verticalLayout"));
        horizontalLayout = new QHBoxLayout();
        horizontalLayout->setObjectName(QString::fromUtf8("horizontalLayout"));
        cbbMethod = new QComboBox(queryStu);
        cbbMethod->addItem(QString());
        cbbMethod->addItem(QString());
        cbbMethod->addItem(QString());
        cbbMethod->addItem(QString());
        cbbMethod->setObjectName(QString::fromUtf8("cbbMethod"));

        horizontalLayout->addWidget(cbbMethod);

        leCnt = new QLineEdit(queryStu);
        leCnt->setObjectName(QString::fromUtf8("leCnt"));

        horizontalLayout->addWidget(leCnt);

        btnSearch = new QPushButton(queryStu);
        btnSearch->setObjectName(QString::fromUtf8("btnSearch"));

        horizontalLayout->addWidget(btnSearch);

        btnClear = new QPushButton(queryStu);
        btnClear->setObjectName(QString::fromUtf8("btnClear"));

        horizontalLayout->addWidget(btnClear);

        horizontalLayout->setStretch(0, 2);
        horizontalLayout->setStretch(1, 10);
        horizontalLayout->setStretch(2, 1);

        verticalLayout->addLayout(horizontalLayout);

        tableView = new QTableView(queryStu);
        tableView->setObjectName(QString::fromUtf8("tableView"));

        verticalLayout->addWidget(tableView);

        verticalLayout->setStretch(0, 2);
        verticalLayout->setStretch(1, 8);

        verticalLayout_2->addLayout(verticalLayout);


        retranslateUi(queryStu);

        QMetaObject::connectSlotsByName(queryStu);
    } // setupUi

    void retranslateUi(QDialog *queryStu)
    {
        queryStu->setWindowTitle(QApplication::translate("queryStu", "\346\237\245\350\257\242\345\255\246\347\224\237", nullptr));
        cbbMethod->setItemText(0, QApplication::translate("queryStu", "\351\200\211\346\213\251\346\237\245\350\257\242\346\226\271\345\274\217", nullptr));
        cbbMethod->setItemText(1, QApplication::translate("queryStu", "\346\214\211\345\247\223\345\220\215", nullptr));
        cbbMethod->setItemText(2, QApplication::translate("queryStu", "\346\214\211\345\255\246\345\217\267", nullptr));
        cbbMethod->setItemText(3, QApplication::translate("queryStu", "\346\214\211\351\231\242\347\263\273", nullptr));

        btnSearch->setText(QApplication::translate("queryStu", "\345\274\200\345\247\213\346\237\245\350\257\242", nullptr));
        btnClear->setText(QApplication::translate("queryStu", "\346\270\205\351\231\244\344\277\241\346\201\257", nullptr));
    } // retranslateUi

};

namespace Ui {
    class queryStu: public Ui_queryStu {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_QUERYSTU_H
