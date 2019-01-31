/********************************************************************************
** Form generated from reading UI file 'mainwindow.ui'
**
** Created by: Qt User Interface Compiler version 5.12.0
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_MAINWINDOW_H
#define UI_MAINWINDOW_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QGridLayout>
#include <QtWidgets/QLabel>
#include <QtWidgets/QMainWindow>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QVBoxLayout>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_MainWindow
{
public:
    QWidget *centralWidget;
    QVBoxLayout *verticalLayout;
    QLabel *lblDisplay;
    QGridLayout *gridLayout;
    QPushButton *btn1;
    QPushButton *btn3;
    QPushButton *btn2;
    QPushButton *btn6;
    QPushButton *btnSub;
    QPushButton *btn0;
    QPushButton *btn5;
    QPushButton *btnMul;
    QPushButton *btnAC;
    QPushButton *btnEqual;
    QPushButton *btnDiv;
    QPushButton *btn7;
    QPushButton *btn8;
    QPushButton *btn9;
    QPushButton *btnAdd;
    QPushButton *btn4;

    void setupUi(QMainWindow *MainWindow)
    {
        if (MainWindow->objectName().isEmpty())
            MainWindow->setObjectName(QString::fromUtf8("MainWindow"));
        MainWindow->resize(420, 600);
        MainWindow->setMinimumSize(QSize(420, 600));
        MainWindow->setMaximumSize(QSize(420, 600));
        MainWindow->setStyleSheet(QString::fromUtf8(""));
        MainWindow->setUnifiedTitleAndToolBarOnMac(false);
        centralWidget = new QWidget(MainWindow);
        centralWidget->setObjectName(QString::fromUtf8("centralWidget"));
        verticalLayout = new QVBoxLayout(centralWidget);
        verticalLayout->setSpacing(6);
        verticalLayout->setContentsMargins(11, 11, 11, 11);
        verticalLayout->setObjectName(QString::fromUtf8("verticalLayout"));
        lblDisplay = new QLabel(centralWidget);
        lblDisplay->setObjectName(QString::fromUtf8("lblDisplay"));
        QFont font;
        font.setPointSize(58);
        lblDisplay->setFont(font);
        lblDisplay->setStyleSheet(QString::fromUtf8("background-color: rgb(114, 159, 207);"));
        lblDisplay->setAlignment(Qt::AlignRight|Qt::AlignTrailing|Qt::AlignVCenter);

        verticalLayout->addWidget(lblDisplay);

        gridLayout = new QGridLayout();
        gridLayout->setSpacing(6);
        gridLayout->setObjectName(QString::fromUtf8("gridLayout"));
        btn1 = new QPushButton(centralWidget);
        btn1->setObjectName(QString::fromUtf8("btn1"));
        QSizePolicy sizePolicy(QSizePolicy::Minimum, QSizePolicy::Expanding);
        sizePolicy.setHorizontalStretch(0);
        sizePolicy.setVerticalStretch(0);
        sizePolicy.setHeightForWidth(btn1->sizePolicy().hasHeightForWidth());
        btn1->setSizePolicy(sizePolicy);
        QFont font1;
        font1.setPointSize(30);
        btn1->setFont(font1);

        gridLayout->addWidget(btn1, 0, 0, 1, 1);

        btn3 = new QPushButton(centralWidget);
        btn3->setObjectName(QString::fromUtf8("btn3"));
        sizePolicy.setHeightForWidth(btn3->sizePolicy().hasHeightForWidth());
        btn3->setSizePolicy(sizePolicy);
        btn3->setFont(font1);

        gridLayout->addWidget(btn3, 0, 2, 1, 1);

        btn2 = new QPushButton(centralWidget);
        btn2->setObjectName(QString::fromUtf8("btn2"));
        sizePolicy.setHeightForWidth(btn2->sizePolicy().hasHeightForWidth());
        btn2->setSizePolicy(sizePolicy);
        btn2->setFont(font1);

        gridLayout->addWidget(btn2, 0, 1, 1, 1);

        btn6 = new QPushButton(centralWidget);
        btn6->setObjectName(QString::fromUtf8("btn6"));
        sizePolicy.setHeightForWidth(btn6->sizePolicy().hasHeightForWidth());
        btn6->setSizePolicy(sizePolicy);
        btn6->setFont(font1);

        gridLayout->addWidget(btn6, 1, 2, 1, 1);

        btnSub = new QPushButton(centralWidget);
        btnSub->setObjectName(QString::fromUtf8("btnSub"));
        sizePolicy.setHeightForWidth(btnSub->sizePolicy().hasHeightForWidth());
        btnSub->setSizePolicy(sizePolicy);
        btnSub->setFont(font1);

        gridLayout->addWidget(btnSub, 1, 3, 1, 1);

        btn0 = new QPushButton(centralWidget);
        btn0->setObjectName(QString::fromUtf8("btn0"));
        sizePolicy.setHeightForWidth(btn0->sizePolicy().hasHeightForWidth());
        btn0->setSizePolicy(sizePolicy);
        btn0->setFont(font1);

        gridLayout->addWidget(btn0, 3, 1, 1, 1);

        btn5 = new QPushButton(centralWidget);
        btn5->setObjectName(QString::fromUtf8("btn5"));
        sizePolicy.setHeightForWidth(btn5->sizePolicy().hasHeightForWidth());
        btn5->setSizePolicy(sizePolicy);
        btn5->setFont(font1);

        gridLayout->addWidget(btn5, 1, 1, 1, 1);

        btnMul = new QPushButton(centralWidget);
        btnMul->setObjectName(QString::fromUtf8("btnMul"));
        sizePolicy.setHeightForWidth(btnMul->sizePolicy().hasHeightForWidth());
        btnMul->setSizePolicy(sizePolicy);
        btnMul->setFont(font1);

        gridLayout->addWidget(btnMul, 2, 3, 1, 1);

        btnAC = new QPushButton(centralWidget);
        btnAC->setObjectName(QString::fromUtf8("btnAC"));
        sizePolicy.setHeightForWidth(btnAC->sizePolicy().hasHeightForWidth());
        btnAC->setSizePolicy(sizePolicy);
        btnAC->setFont(font1);

        gridLayout->addWidget(btnAC, 3, 0, 1, 1);

        btnEqual = new QPushButton(centralWidget);
        btnEqual->setObjectName(QString::fromUtf8("btnEqual"));
        sizePolicy.setHeightForWidth(btnEqual->sizePolicy().hasHeightForWidth());
        btnEqual->setSizePolicy(sizePolicy);
        btnEqual->setFont(font1);

        gridLayout->addWidget(btnEqual, 3, 2, 1, 1);

        btnDiv = new QPushButton(centralWidget);
        btnDiv->setObjectName(QString::fromUtf8("btnDiv"));
        sizePolicy.setHeightForWidth(btnDiv->sizePolicy().hasHeightForWidth());
        btnDiv->setSizePolicy(sizePolicy);
        btnDiv->setFont(font1);

        gridLayout->addWidget(btnDiv, 3, 3, 1, 1);

        btn7 = new QPushButton(centralWidget);
        btn7->setObjectName(QString::fromUtf8("btn7"));
        sizePolicy.setHeightForWidth(btn7->sizePolicy().hasHeightForWidth());
        btn7->setSizePolicy(sizePolicy);
        btn7->setFont(font1);

        gridLayout->addWidget(btn7, 2, 0, 1, 1);

        btn8 = new QPushButton(centralWidget);
        btn8->setObjectName(QString::fromUtf8("btn8"));
        sizePolicy.setHeightForWidth(btn8->sizePolicy().hasHeightForWidth());
        btn8->setSizePolicy(sizePolicy);
        btn8->setFont(font1);

        gridLayout->addWidget(btn8, 2, 1, 1, 1);

        btn9 = new QPushButton(centralWidget);
        btn9->setObjectName(QString::fromUtf8("btn9"));
        sizePolicy.setHeightForWidth(btn9->sizePolicy().hasHeightForWidth());
        btn9->setSizePolicy(sizePolicy);
        btn9->setFont(font1);

        gridLayout->addWidget(btn9, 2, 2, 1, 1);

        btnAdd = new QPushButton(centralWidget);
        btnAdd->setObjectName(QString::fromUtf8("btnAdd"));
        sizePolicy.setHeightForWidth(btnAdd->sizePolicy().hasHeightForWidth());
        btnAdd->setSizePolicy(sizePolicy);
        btnAdd->setFont(font1);

        gridLayout->addWidget(btnAdd, 0, 3, 1, 1);

        btn4 = new QPushButton(centralWidget);
        btn4->setObjectName(QString::fromUtf8("btn4"));
        sizePolicy.setHeightForWidth(btn4->sizePolicy().hasHeightForWidth());
        btn4->setSizePolicy(sizePolicy);
        btn4->setFont(font1);

        gridLayout->addWidget(btn4, 1, 0, 1, 1);


        verticalLayout->addLayout(gridLayout);

        verticalLayout->setStretch(0, 2);
        verticalLayout->setStretch(1, 8);
        MainWindow->setCentralWidget(centralWidget);

        retranslateUi(MainWindow);

        QMetaObject::connectSlotsByName(MainWindow);
    } // setupUi

    void retranslateUi(QMainWindow *MainWindow)
    {
        MainWindow->setWindowTitle(QApplication::translate("MainWindow", "\350\256\241\347\256\227\345\231\250", nullptr));
        lblDisplay->setText(QApplication::translate("MainWindow", "0", nullptr));
        btn1->setText(QApplication::translate("MainWindow", "1", nullptr));
        btn3->setText(QApplication::translate("MainWindow", "3", nullptr));
        btn2->setText(QApplication::translate("MainWindow", "2", nullptr));
        btn6->setText(QApplication::translate("MainWindow", "6", nullptr));
        btnSub->setText(QApplication::translate("MainWindow", "-", nullptr));
        btn0->setText(QApplication::translate("MainWindow", "0", nullptr));
        btn5->setText(QApplication::translate("MainWindow", "5", nullptr));
        btnMul->setText(QApplication::translate("MainWindow", "*", nullptr));
        btnAC->setText(QApplication::translate("MainWindow", "AC", nullptr));
        btnEqual->setText(QApplication::translate("MainWindow", "=", nullptr));
        btnDiv->setText(QApplication::translate("MainWindow", "/", nullptr));
        btn7->setText(QApplication::translate("MainWindow", "7", nullptr));
        btn8->setText(QApplication::translate("MainWindow", "8", nullptr));
        btn9->setText(QApplication::translate("MainWindow", "9", nullptr));
        btnAdd->setText(QApplication::translate("MainWindow", "+", nullptr));
        btn4->setText(QApplication::translate("MainWindow", "4", nullptr));
    } // retranslateUi

};

namespace Ui {
    class MainWindow: public Ui_MainWindow {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_MAINWINDOW_H
