/*###Begin banned keyword - each of the following line if appear in code will raise error. regex supported
define
include
using
std
###End banned keyword*/

#include <iostream>
#include <limits>
using namespace std;

class SinglyLinkedListNode {
    public:
        int data;
        SinglyLinkedListNode *next;

        SinglyLinkedListNode(int node_data) {
            this->data = node_data;
            this->next = nullptr;
        }
};

class SinglyLinkedList {
    public:
        SinglyLinkedListNode *head;
        SinglyLinkedListNode *tail;

        SinglyLinkedList() {
            this->head = nullptr;
            this->tail = nullptr;
        }

        void insert_node(int node_data) {
            SinglyLinkedListNode* node = new SinglyLinkedListNode(node_data);

            if (!this->head) {
                this->head = node;
            } else {
                this->tail->next = node;
            }

            this->tail = node;
        }
};

void free_singly_linked_list(SinglyLinkedListNode* node) {
    while (node) {
        SinglyLinkedListNode* temp = node;
        node = node->next;

        free(temp);
    }
}

void printLinkedList(SinglyLinkedListNode* head) {
    while (head != NULL){
        cout<< head->data << ' ';
        head = head->next;
    }
}


// Complete the insertSortedLinkedList function below.

/*
 * For your reference:
 *
 * SinglyLinkedListNode {
 *     int data;
 *     SinglyLinkedListNode* next;
 * };
 *
 */
SinglyLinkedListNode* insertSortedLinkedList(SinglyLinkedListNode* head, int x) {
    // B1: Nếu danh sách đang rỗng
    if (head == nullptr) {
        SinglyLinkedListNode* newnode = new SinglyLinkedListNode(x);
        return newnode; // newnode trở thành head
    }

    // B2: Nếu giá trị cần chèn <= head->data => chèn trước head
    if (x <= head->data) {
        SinglyLinkedListNode* newnode = new SinglyLinkedListNode(x);
        newnode->next = head;
        return newnode;
    }

    // B3: Duyệt danh sách để tìm vị trí chèn
    SinglyLinkedListNode* cur = head;
    while (cur->next != nullptr && cur->next->data < x) {
        cur = cur->next;
    }

    // Khi thoát vòng while, cur là node cuối cùng có data < x
    // hoặc cur->next = nullptr (tức đã duyệt hết list)
    SinglyLinkedListNode* newnode = new SinglyLinkedListNode(x);
    newnode->next = cur->next;   // Gắn newnode trỏ đến node kế tiếp
    cur->next = newnode;         // Gắn node hiện tại trỏ sang newnode

    return head;
}


int main()
{
    SinglyLinkedList* llist = new SinglyLinkedList();
    int llist_count;
    int x;

    cin >> llist_count;
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    for (int i = 0; i < llist_count; i++) {
        int llist_item;
        cin >> llist_item;
        cin.ignore(numeric_limits<streamsize>::max(), '\n');

        llist->insert_node(llist_item);
    }
    cin >> x;
    llist->head = insertSortedLinkedList(llist->head, x);
    printLinkedList(llist->head);

    return 0;
}
