class Node:
    def __init__(self, termination=False, children=None):
        self.termination = termination
        self.children = {} if children is None else children


class Trie:
    def __init__(self):
        self.root = Node()

    def insert(self, text):
        node = self.root
        for (index, letter) in enumerate(text):
            if node.children.get(letter, None) is None:
                node.children[letter] = Node()
            node = node.children[letter]
            if index is len(text) - 1:
                node.termination = True

    def search(self, preffix):
        node = self.root
        for (index, letter) in enumerate(preffix):
            node = node.children.get(letter, None)
            if node is None:
                return False
            if index is len(preffix) - 1 and not node.termination:
                return False
        return True


trie = Trie()
text = "maxim"
for i, _ in enumerate(text):
    if i is len(text) - 1:
        break
    trie.insert(text[i:])

for i, _ in enumerate(text):
    print(trie.search(text[i:]))