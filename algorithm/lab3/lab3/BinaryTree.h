#pragma once
#include <string>
#include <iostream>

using namespace std;

struct abonent
{
	string name;
	string number;

	abonent(string name, string number) {
		this->name = name;
		this->number = number;
	}
};

struct node {
	abonent data;
	node *left;
	node *right;

	node(string name, string number)
		:data(name, number), left(nullptr), right(nullptr)
	{}
};

class BinaryTree
{
private:
	node * root;

	node* search(node *n, string name);
	int insert(node*& n, string name, string number);
	void walk(node* n);

public:
	BinaryTree(string name, string number);
	BinaryTree(abonent abn);
	~BinaryTree();

	node* search(string name);
	int insert(string name, string number);
	int insert(abonent abn);
	void walk();
};

