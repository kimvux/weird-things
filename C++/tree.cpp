#include <bits/stdc++.h>
using namespace std;

struct node {
    int info;
    node *left, *right;
};

node* creatNode(int x){
    node *a;
    a = new node;
    a->info = x;
    a->left = a->right = nullptr;
    return a;
}

struct tree {
    node *root = nullptr;
};

void addNode(tree &a, int x){
    if (a.root == nullptr){
        a.root = creatNode(x);
        return;
    }
    node *p = a.root;
    while(p){
        if (p->info == x)
            return;

        if (p->info < x && p->right != nullptr)
            p = p->right;
        else if (p->info > x && p->left != nullptr)
            p = p->left;

        else if (p->info < x && p->right == nullptr){
            p->right = creatNode(x);
            break;
        }
        else if (p->info > x && p->left == nullptr){
            p->left = creatNode(x);
            break;
        }
    }
}

int treeHeight(tree &a, node *x){
    if (x == nullptr) return 0;
    int l = treeHeight(a,x->left);
    int r = treeHeight(a,x->right);
    return l > r ? l+1 : r+1;
}

void NLR(tree &a, node *x){
    if (x == nullptr)
        return;
    cout << x->info << " ";
    NLR(a,x->left);
    NLR(a,x->right);
}



int count2childs(tree &a){
    if (a.root == nullptr) return 0;
    queue<node*> q;
    q.push(a.root);
    int count = 0;
    while(!q.empty()){
        node* p = q.front();
        q.pop();
        if (p->left != nullptr && p->right != nullptr)
            count++;
        if (p->left != nullptr)
            q.push(p->left);
        if (p->right != nullptr)
            q.push(p->right);
    }
    return count;
}


int main(){
    tree a;
    int x,num;
    cin >> x;
    for (int i=0; i<x ; ++i){
        cin >> num;
        addNode(a,num);
    }
    cout << count2childs(a);
    return 0;
}
