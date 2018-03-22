/* bin - manipulates binary trees.
   Derived from libavl for manipulation of binary trees.
   Copyright (C) 1998-2000 Free Software Foundation, Inc.

   This program is free software; you can redistribute it and/or
   modify it under the terms of the GNU General Public License as
   published by the Free Software Foundation; either version 2 of the
   License, or (at your option) any later version.

   This program is distributed in the hope that it will be useful, but
   WITHOUT ANY WARRANTY; without even the implied warranty of
   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
   General Public License for more details.

   You should have received a copy of the GNU General Public License
   along with this program; if not, write to the Free Software
   Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA
   02111-1307, USA.

   The author may be contacted at <pfaffben@msu.edu> on the Internet,
   or as Ben Pfaff, 12167 Airport Rd, DeWitt MI 48820, USA through
   more mundane means. */

#include "bin.h"

   /* Creates and returns a new binary tree.  Returns a null pointer if a
	  memory allocation error occurs. */
struct bin_tree *bin_create(void)
{
	struct bin_tree *tree = malloc(sizeof *tree);
	if (tree == NULL)
		return NULL;
	tree->root = NULL;
	tree->count = 0;
	return tree;
}

/* Searches TREE for matching ITEM.  Returns 1 if found, 0
   otherwise. */
int bin_search(const struct bin_tree *tree, char name[])
{
	const struct bin_node *node;

	assert(tree != NULL);
	node = tree->root;
	for (;;) {
		if (node == NULL)
			return 0;
		else if (name == node->data.name)
			return 1;
		else if (name > node->data.name)
			node = node->right;
		else
			node = node->left;
	}
}

/* Inserts ITEM into TREE.  Returns 1 if the item was inserted, 2 if
   an identical item already existed in TREE, or 0 if a memory
   allocation error occurred. */
int bin_insert(struct bin_tree *tree, struct abonent abn)
{
	struct bin_node *node, **new;

	assert(tree != NULL);
	new = &tree->root;
	node = tree->root;
	for (;;) {
		if (node == NULL) {
			node = *new = malloc(sizeof *node);
			if (node != NULL) {
				node->data = abn;
				node->left = node->right = NULL;
				tree->count++;
				return 1;
			}
			else
				return 0;
		}
		else if (abn.name == node->data.name)
			return 2;
		else if (abn.name > node->data.name) {
			new = &node->right;
			node = node->right;
		}
		else {
			new = &node->left;
			node = node->left;
		}
	}
}

/* Deletes any item matching ITEM from TREE.  Returns 1 if such an
   item was deleted, 0 if none was found. */
int bin_delete(struct bin_tree *tree, char name[])
{
	struct bin_node **q, *z;

	assert(tree != NULL);
	q = &tree->root;
	z = tree->root;
	for (;;) {
		if (z == NULL)
			return 0;
		else if (name == z->data.name)
			break;
		else if (name > z->data.name) {
			q = &z->right;
			z = z->right;
		}
		else {
			q = &z->left;
			z = z->left;
		}
	}

	if (z->right == NULL)
		*q = z->left;
	else {
		struct bin_node *y = z->right;
		if (y->left == NULL) {
			y->left = z->left;
			*q = y;
		}
		else {
			struct bin_node *x = y->left;
			while (x->left != NULL) {
				y = x;
				x = y->left;
			}
			y->left = x->right;
			x->left = z->left;
			x->right = z->right;
			*q = x;
		}
	}

	tree->count--;
	free(z);
	return 1;
}

/* Helper function for bin_walk().  Recursively prints data from each
   node in tree rooted at NODE in in-order. */
static void walk(const struct bin_node *node)
{
	if (node == NULL)
		return;
	walk(node->left);
	printf("%d ", node->data);
	walk(node->right);
}

/* Prints all the data items in TREE in in-order. */
void bin_walk(const struct bin_tree *tree)
{
	assert(tree != NULL);
	walk(tree->root);
}

/* Prints all the data items in TREE in in-order, using an iterative
   algorithm. */
void bin_traverse(const struct bin_tree *tree)
{
	struct bin_node *stack[32];
	int count;

	struct bin_node *node;

	assert(tree != NULL);
	count = 0;
	node = tree->root;
	for (;;) {
		while (node != NULL) {
			stack[count++] = node;
			node = node->left;
		}
		if (count == 0)
			return;
		node = stack[--count];
		printf("%d ", node->data);
		node = node->right;
	}
}

/* Destroys tree rooted at NODE. */
static void destroy(struct bin_node *node)
{
	if (node == NULL)
		return;
	destroy(node->left);
	destroy(node->right);
	free(node);
}

/* Destroys TREE. */
void bin_destroy(struct bin_tree *tree)
{
	assert(tree != NULL);
	destroy(tree->root);
	free(tree);
}

/* Returns the number of data items in TREE. */
int bin_count(const struct bin_tree *tree)
{
	assert(tree != NULL);
	return tree->count;
}

/* Print the structure of node NODE of an binary tree, which is LEVEL
   levels from the top of the tree.  Uses different delimiters to
   visually distinguish levels. */
void print_structure(struct bin_node *node, int level)
{
	assert(level <= 100);

	if (node == NULL) {
		printf(" nil");
		return;
	}
	printf(" %c%s%l", "([{`/"[level % 5], node->data.name, node->data.number);
	if (node->left || node->right) {
		print_structure(node->left, level + 1);
		if (node->right)
			print_structure(node->right, level + 1);
	}
	printf("%c", ")]}'\\"[level % 5]);
}

/* Size of tree used for testing. */
#define TREE_SIZE 4

/* Simple stress test procedure for the binary tree routines.  Does
   the following:

   * Generate a random number seed.  By default this is generated from
   the current time.  You can also pass an integer seed value on the
   command line if you want to test the same case.  The seed value is
   displayed.

   * Create a tree and insert the integers from 0 up to TREE_SIZE - 1
   into it, in random order.  Verifies and displays the tree structure
   after each insertion.

   * Removes each integer from the tree, in a different random order.
   Verifies and displays the tree structure after each deletion.

   * Destroys the tree.

   This is pretty good test code if you write some of your own binary
   tree routines.  If you do so you will probably want to modify the
   code below so that it increments the random seed and goes on to new
   test cases automatically. 
int main(int argc, char **argv)
{
	struct abonent array[TREE_SIZE];
	struct bin_tree *tree;
	int i;


	tree = bin_create();

	for (i = 0; i < TREE_SIZE; i++) {
		int result = bin_insert(tree, array[i]);
		if (result != 1) {
			printf("Error %d inserting element %d, %d, into tree.\n",
				result, i, array[i]);
			exit(EXIT_FAILURE);
		}

		printf("Inserted %d: ", array[i]);
		bin_walk(tree);
		putchar('\n');

		verify_tree(tree, array);
	}

	shuffle(array, TREE_SIZE);
	for (i = 0; i < TREE_SIZE; i++) {
		if (bin_delete(tree, array[i].name) == 0) {
			printf("Error removing element %d, %d, from tree.\n", i, array[i]);
			exit(EXIT_FAILURE);
		}

		printf("Removed %d: ", array[i]);
		bin_traverse(tree);
		putchar('\n');

		verify_tree(tree, array + i + 1);
	}

	bin_destroy(tree);
	printf("Success!\n");

	return EXIT_SUCCESS;
}
*/