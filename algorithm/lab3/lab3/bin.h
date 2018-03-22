#pragma once

#include "stdafx.h"
#include <assert.h>
#include <limits.h>
#include <stdio.h>
#include <stdlib.h>
#include <time.h>

struct abonent
{
	char name[128];
	long number;
};

struct bin_node {
	struct abonent data;
	struct bin_node *left;
	struct bin_node *right;
};

struct bin_tree {
	struct bin_node *root;
	int count;
};

struct bin_tree *bin_create(void);

int bin_search(const struct bin_tree *tree, char name[]);

int bin_insert(struct bin_tree *tree, struct abonent abn);

int bin_delete(struct bin_tree *tree, char name[]);

static void walk(const struct bin_node *node);

void bin_walk(const struct bin_tree *tree);

void bin_traverse(const struct bin_tree *tree);

static void destroy(struct bin_node *node);

void bin_destroy(struct bin_tree *tree);

int bin_count(const struct bin_tree *tree);

void print_structure(struct bin_node *node, int level);