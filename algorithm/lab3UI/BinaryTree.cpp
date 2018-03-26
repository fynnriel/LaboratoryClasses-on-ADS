#include "BinaryTree.h"


BinaryTree::BinaryTree(string name, string number)
{
	root = new node(name, number);
}

BinaryTree::BinaryTree(abonent abn)
{
	root = new node(abn.name, abn.number);
}

BinaryTree::~BinaryTree()
{
}

node* BinaryTree::search(string name) {
	return search(root, name);
}

int BinaryTree::insert(string name, string number)
{
	return insert(root, name, number);
}

int BinaryTree::insert(abonent abn)
{
	return insert(abn.name, abn.number);
}

string BinaryTree::walk()
{
    return walk(root);
}


node* BinaryTree::search(node *n, string name)
{
	if (n == nullptr)
		return nullptr;
	if (n->data.name == name || n->data.number == name)
		return n;
	else if (name.compare(n->data.name) > 0 && n->right != nullptr)
		return search(n->right, name);
	else if (name.compare(n->data.name) < 0 && n->left != nullptr)
		return search(n->left, name);
	else
		return nullptr;
}

int BinaryTree::insert(node*& n, string name, string number)
{
	if (n == nullptr) {
		n = new node(name, number);
		return 1;
	}
	else if (n->data.name.compare(name) == 0) {
		return 0;
	}
	else if (name.compare(n->data.name) > 0) {
		return insert(n->right, name, number);
	}
	else {
		return insert(n->left, name, number);
	}
}

string BinaryTree::walk(node* n)
{
    string s;
	if (n == NULL)
        return s;
    s += walk(n->left);
    s += n->data.name + "|" + n->data.number + '\n';
    s += walk(n->right);
    return s;
}

