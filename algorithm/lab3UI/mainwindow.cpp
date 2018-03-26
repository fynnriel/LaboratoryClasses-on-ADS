#include "mainwindow.h"
#include "ui_mainwindow.h"

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    abonent abn1("Sergey Bayramov", "89313112511");
    abonent abn2("Sergey Evdokimov", "89221578977");
    abonent abn3("Sasha Vatrakshina", "87997417777");
    abonent abn4("Natalya Bayramova", "89631410171");

    tree = new BinaryTree(abn3);
    tree->insert(abn1);
    tree->insert(abn2);
    tree->insert(abn4);

    ui->setupUi(this);
}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::on_pushButton_clicked()
{
    ui->plainTextEdit->clear();
    ui->plainTextEdit->moveCursor(QTextCursor::End);
    ui->plainTextEdit->insertPlainText(QString::fromStdString(tree->walk()));
    ui->plainTextEdit->moveCursor(QTextCursor::End);
}

void MainWindow::on_pushButton_2_clicked()
{
    int price = 0;
    int minutes = 0;
    int seconds = 0;

    try{
     price =std::stoi(ui->lineEdit_3->text().toStdString());
    }
    catch(exception e){}
    try{
     minutes = std::stoi(ui->lineEdit->text().toStdString());
    }
    catch(exception e){}
    try{
     seconds = std::stoi(ui->lineEdit_2->text().toStdString());
    }
    catch(exception e){}


    minutes += seconds / 60;
    seconds = seconds % 60;
    node* node = tree->search(ui->lineEdit_4->text().toStdString());
    if (node == nullptr)
        return;
    int additonal = 0;
    if (seconds > 0)
        ++additonal;
    string s = "Name: ";
    s += node->data.name;
    s += "\nNumber: ";
    s += node->data.number;
    s += "\nDialog time: ";
    s += std::to_string(minutes);
    s += "m ";
    s += std::to_string(seconds);
    s += "s\nPrice: ";
    s += std::to_string(minutes * price + additonal * price);
    s += "\n";
    std::cout << s;
    ui->plainTextEdit->clear();
    ui->plainTextEdit->moveCursor(QTextCursor::End);
    ui->plainTextEdit->insertPlainText(QString::fromStdString(s));
    ui->plainTextEdit->moveCursor(QTextCursor::End);
}
