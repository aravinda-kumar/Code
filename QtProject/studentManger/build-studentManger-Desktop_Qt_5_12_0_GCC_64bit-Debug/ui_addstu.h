/********************************************************************************
** Form generated from reading UI file 'addstu.ui'
**
** Created by: Qt User Interface Compiler version 5.12.0
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_ADDSTU_H
#define UI_ADDSTU_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QCheckBox>
#include <QtWidgets/QComboBox>
#include <QtWidgets/QDialog>
#include <QtWidgets/QGridLayout>
#include <QtWidgets/QHBoxLayout>
#include <QtWidgets/QLabel>
#include <QtWidgets/QLineEdit>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QRadioButton>
#include <QtWidgets/QSpacerItem>
#include <QtWidgets/QVBoxLayout>

QT_BEGIN_NAMESPACE

class Ui_addStu
{
public:
    QVBoxLayout *verticalLayout;
    QLabel *label;
    QHBoxLayout *horizontalLayout;
    QLabel *label_2;
    QLineEdit *le_Name;
    QHBoxLayout *horizontalLayout_2;
    QLabel *label_3;
    QLineEdit *le_ID;
    QHBoxLayout *horizontalLayout_3;
    QLabel *label_4;
    QRadioButton *rbtn_Male;
    QRadioButton *rbtn_Femal;
    QHBoxLayout *horizontalLayout_5;
    QLabel *label_5;
    QComboBox *cbb_Age;
    QSpacerItem *horizontalSpacer_2;
    QHBoxLayout *horizontalLayout_4;
    QLabel *label_6;
    QComboBox *cbb_School;
    QSpacerItem *horizontalSpacer_3;
    QHBoxLayout *horizontalLayout_6;
    QLabel *label_7;
    QGridLayout *gridLayout;
    QCheckBox *checkBox;
    QCheckBox *checkBox_2;
    QCheckBox *checkBox_4;
    QCheckBox *checkBox_3;
    QHBoxLayout *horizontalLayout_7;
    QPushButton *btn_OK;
    QSpacerItem *horizontalSpacer;
    QPushButton *btn_Cancel;

    void setupUi(QDialog *addStu)
    {
        if (addStu->objectName().isEmpty())
            addStu->setObjectName(QString::fromUtf8("addStu"));
        addStu->resize(350, 480);
        addStu->setMinimumSize(QSize(350, 480));
        addStu->setMaximumSize(QSize(350, 480));
        verticalLayout = new QVBoxLayout(addStu);
        verticalLayout->setSpacing(6);
        verticalLayout->setContentsMargins(11, 11, 11, 11);
        verticalLayout->setObjectName(QString::fromUtf8("verticalLayout"));
        label = new QLabel(addStu);
        label->setObjectName(QString::fromUtf8("label"));
        QSizePolicy sizePolicy(QSizePolicy::Preferred, QSizePolicy::Fixed);
        sizePolicy.setHorizontalStretch(0);
        sizePolicy.setVerticalStretch(0);
        sizePolicy.setHeightForWidth(label->sizePolicy().hasHeightForWidth());
        label->setSizePolicy(sizePolicy);
        QFont font;
        font.setPointSize(30);
        label->setFont(font);
        label->setAlignment(Qt::AlignCenter);

        verticalLayout->addWidget(label);

        horizontalLayout = new QHBoxLayout();
        horizontalLayout->setSpacing(6);
        horizontalLayout->setObjectName(QString::fromUtf8("horizontalLayout"));
        label_2 = new QLabel(addStu);
        label_2->setObjectName(QString::fromUtf8("label_2"));

        horizontalLayout->addWidget(label_2);

        le_Name = new QLineEdit(addStu);
        le_Name->setObjectName(QString::fromUtf8("le_Name"));
        le_Name->setClearButtonEnabled(true);

        horizontalLayout->addWidget(le_Name);

        horizontalLayout->setStretch(0, 1);
        horizontalLayout->setStretch(1, 8);

        verticalLayout->addLayout(horizontalLayout);

        horizontalLayout_2 = new QHBoxLayout();
        horizontalLayout_2->setSpacing(6);
        horizontalLayout_2->setObjectName(QString::fromUtf8("horizontalLayout_2"));
        label_3 = new QLabel(addStu);
        label_3->setObjectName(QString::fromUtf8("label_3"));

        horizontalLayout_2->addWidget(label_3);

        le_ID = new QLineEdit(addStu);
        le_ID->setObjectName(QString::fromUtf8("le_ID"));
        le_ID->setEchoMode(QLineEdit::Normal);
        le_ID->setClearButtonEnabled(true);

        horizontalLayout_2->addWidget(le_ID);

        horizontalLayout_2->setStretch(0, 1);
        horizontalLayout_2->setStretch(1, 8);

        verticalLayout->addLayout(horizontalLayout_2);

        horizontalLayout_3 = new QHBoxLayout();
        horizontalLayout_3->setSpacing(6);
        horizontalLayout_3->setObjectName(QString::fromUtf8("horizontalLayout_3"));
        label_4 = new QLabel(addStu);
        label_4->setObjectName(QString::fromUtf8("label_4"));

        horizontalLayout_3->addWidget(label_4);

        rbtn_Male = new QRadioButton(addStu);
        rbtn_Male->setObjectName(QString::fromUtf8("rbtn_Male"));
        rbtn_Male->setChecked(true);

        horizontalLayout_3->addWidget(rbtn_Male);

        rbtn_Femal = new QRadioButton(addStu);
        rbtn_Femal->setObjectName(QString::fromUtf8("rbtn_Femal"));

        horizontalLayout_3->addWidget(rbtn_Femal);

        horizontalLayout_3->setStretch(0, 1);
        horizontalLayout_3->setStretch(1, 4);
        horizontalLayout_3->setStretch(2, 4);

        verticalLayout->addLayout(horizontalLayout_3);

        horizontalLayout_5 = new QHBoxLayout();
        horizontalLayout_5->setSpacing(6);
        horizontalLayout_5->setObjectName(QString::fromUtf8("horizontalLayout_5"));
        label_5 = new QLabel(addStu);
        label_5->setObjectName(QString::fromUtf8("label_5"));

        horizontalLayout_5->addWidget(label_5);

        cbb_Age = new QComboBox(addStu);
        cbb_Age->addItem(QString());
        cbb_Age->addItem(QString());
        cbb_Age->addItem(QString());
        cbb_Age->addItem(QString());
        cbb_Age->addItem(QString());
        cbb_Age->addItem(QString());
        cbb_Age->addItem(QString());
        cbb_Age->addItem(QString());
        cbb_Age->setObjectName(QString::fromUtf8("cbb_Age"));

        horizontalLayout_5->addWidget(cbb_Age);

        horizontalSpacer_2 = new QSpacerItem(40, 20, QSizePolicy::Expanding, QSizePolicy::Minimum);

        horizontalLayout_5->addItem(horizontalSpacer_2);

        horizontalLayout_5->setStretch(0, 1);
        horizontalLayout_5->setStretch(1, 4);
        horizontalLayout_5->setStretch(2, 4);

        verticalLayout->addLayout(horizontalLayout_5);

        horizontalLayout_4 = new QHBoxLayout();
        horizontalLayout_4->setSpacing(6);
        horizontalLayout_4->setObjectName(QString::fromUtf8("horizontalLayout_4"));
        label_6 = new QLabel(addStu);
        label_6->setObjectName(QString::fromUtf8("label_6"));

        horizontalLayout_4->addWidget(label_6);

        cbb_School = new QComboBox(addStu);
        cbb_School->addItem(QString());
        cbb_School->addItem(QString());
        cbb_School->addItem(QString());
        cbb_School->addItem(QString());
        cbb_School->setObjectName(QString::fromUtf8("cbb_School"));

        horizontalLayout_4->addWidget(cbb_School);

        horizontalSpacer_3 = new QSpacerItem(40, 20, QSizePolicy::Expanding, QSizePolicy::Minimum);

        horizontalLayout_4->addItem(horizontalSpacer_3);

        horizontalLayout_4->setStretch(0, 1);
        horizontalLayout_4->setStretch(1, 4);
        horizontalLayout_4->setStretch(2, 4);

        verticalLayout->addLayout(horizontalLayout_4);

        horizontalLayout_6 = new QHBoxLayout();
        horizontalLayout_6->setSpacing(6);
        horizontalLayout_6->setObjectName(QString::fromUtf8("horizontalLayout_6"));
        label_7 = new QLabel(addStu);
        label_7->setObjectName(QString::fromUtf8("label_7"));

        horizontalLayout_6->addWidget(label_7);

        gridLayout = new QGridLayout();
        gridLayout->setSpacing(6);
        gridLayout->setObjectName(QString::fromUtf8("gridLayout"));
        checkBox = new QCheckBox(addStu);
        checkBox->setObjectName(QString::fromUtf8("checkBox"));

        gridLayout->addWidget(checkBox, 0, 0, 1, 1);

        checkBox_2 = new QCheckBox(addStu);
        checkBox_2->setObjectName(QString::fromUtf8("checkBox_2"));

        gridLayout->addWidget(checkBox_2, 0, 1, 1, 1);

        checkBox_4 = new QCheckBox(addStu);
        checkBox_4->setObjectName(QString::fromUtf8("checkBox_4"));

        gridLayout->addWidget(checkBox_4, 1, 0, 1, 1);

        checkBox_3 = new QCheckBox(addStu);
        checkBox_3->setObjectName(QString::fromUtf8("checkBox_3"));

        gridLayout->addWidget(checkBox_3, 1, 1, 1, 1);


        horizontalLayout_6->addLayout(gridLayout);

        horizontalLayout_6->setStretch(0, 1);
        horizontalLayout_6->setStretch(1, 8);

        verticalLayout->addLayout(horizontalLayout_6);

        horizontalLayout_7 = new QHBoxLayout();
        horizontalLayout_7->setSpacing(6);
        horizontalLayout_7->setObjectName(QString::fromUtf8("horizontalLayout_7"));
        btn_OK = new QPushButton(addStu);
        btn_OK->setObjectName(QString::fromUtf8("btn_OK"));

        horizontalLayout_7->addWidget(btn_OK);

        horizontalSpacer = new QSpacerItem(40, 20, QSizePolicy::Expanding, QSizePolicy::Minimum);

        horizontalLayout_7->addItem(horizontalSpacer);

        btn_Cancel = new QPushButton(addStu);
        btn_Cancel->setObjectName(QString::fromUtf8("btn_Cancel"));

        horizontalLayout_7->addWidget(btn_Cancel);


        verticalLayout->addLayout(horizontalLayout_7);


        retranslateUi(addStu);

        cbb_Age->setCurrentIndex(0);


        QMetaObject::connectSlotsByName(addStu);
    } // setupUi

    void retranslateUi(QDialog *addStu)
    {
        addStu->setWindowTitle(QApplication::translate("addStu", "\346\267\273\345\212\240\345\255\246\347\224\237", nullptr));
        label->setText(QApplication::translate("addStu", "\346\267\273\345\212\240\345\255\246\347\224\237", nullptr));
        label_2->setText(QApplication::translate("addStu", "\345\247\223\345\220\215:", nullptr));
        le_Name->setInputMask(QString());
        le_Name->setText(QString());
        le_Name->setPlaceholderText(QApplication::translate("addStu", "\350\257\267\350\276\223\345\205\245\345\255\246\347\224\237\345\247\223\345\220\215", nullptr));
        label_3->setText(QApplication::translate("addStu", "\345\255\246\345\217\267:", nullptr));
        le_ID->setPlaceholderText(QApplication::translate("addStu", "\350\257\267\350\276\223\345\205\245\345\255\246\345\217\267(\346\234\200\345\260\22110\344\275\215)", nullptr));
        label_4->setText(QApplication::translate("addStu", "\346\200\247\345\210\253:", nullptr));
        rbtn_Male->setText(QApplication::translate("addStu", "\347\224\267", nullptr));
        rbtn_Femal->setText(QApplication::translate("addStu", "\345\245\263", nullptr));
        label_5->setText(QApplication::translate("addStu", "\345\271\264\351\276\204:", nullptr));
        cbb_Age->setItemText(0, QApplication::translate("addStu", "18", nullptr));
        cbb_Age->setItemText(1, QApplication::translate("addStu", "19", nullptr));
        cbb_Age->setItemText(2, QApplication::translate("addStu", "20", nullptr));
        cbb_Age->setItemText(3, QApplication::translate("addStu", "21", nullptr));
        cbb_Age->setItemText(4, QApplication::translate("addStu", "22", nullptr));
        cbb_Age->setItemText(5, QApplication::translate("addStu", "23", nullptr));
        cbb_Age->setItemText(6, QApplication::translate("addStu", "24", nullptr));
        cbb_Age->setItemText(7, QApplication::translate("addStu", "25", nullptr));

        label_6->setText(QApplication::translate("addStu", "\351\231\242\347\263\273:", nullptr));
        cbb_School->setItemText(0, QApplication::translate("addStu", "\350\256\241\347\256\227\346\234\272\345\255\246\351\231\242", nullptr));
        cbb_School->setItemText(1, QApplication::translate("addStu", "\345\244\226\345\233\275\350\257\255\345\255\246\351\231\242", nullptr));
        cbb_School->setItemText(2, QApplication::translate("addStu", "\345\267\245\345\225\206\347\256\241\347\220\206\345\255\246\351\231\242", nullptr));
        cbb_School->setItemText(3, QApplication::translate("addStu", "\346\261\211\350\257\255\350\250\200\346\226\207\345\255\246\345\255\246\351\231\242", nullptr));

        label_7->setText(QApplication::translate("addStu", "\345\205\264\350\266\243:", nullptr));
        checkBox->setText(QApplication::translate("addStu", "\347\257\256\347\220\203", nullptr));
        checkBox_2->setText(QApplication::translate("addStu", "\346\216\222\347\220\203", nullptr));
        checkBox_4->setText(QApplication::translate("addStu", "\350\266\263\347\220\203", nullptr));
        checkBox_3->setText(QApplication::translate("addStu", "\347\276\275\346\257\233\347\220\203", nullptr));
        btn_OK->setText(QApplication::translate("addStu", "\347\241\256\345\256\232", nullptr));
        btn_Cancel->setText(QApplication::translate("addStu", "\345\217\226\346\266\210", nullptr));
    } // retranslateUi

};

namespace Ui {
    class addStu: public Ui_addStu {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_ADDSTU_H
