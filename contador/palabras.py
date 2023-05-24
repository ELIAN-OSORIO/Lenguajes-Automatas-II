from collections import Counter
import re

file = open('file.txt','r')
char = file.read()
counts = Counter(re.findall(r'\b[A-Za-z]+\b', char))
print(counts)