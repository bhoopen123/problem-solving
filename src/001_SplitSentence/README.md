
## Problem

Split a sentence into words where words within double quotes will also be considered as a single word.

### example

1. input : `This is a sentence`
   
   output : 
   ```
    This
    is
    a
    sentence
   ```

2. input : `This is a sentence "with double quotes"`
   
   output : 
   ```
    This
    is
    a
    sentence
    with double quotes
   ```

3. input : `This is a sentence "with one double quotes" and "another double quotes"`
   
   output : 
   ```
    This
    is
    a
    sentence
    with one double quotes
    another double quotes
   ```

 ## [Solution](/src/001_SplitSentence/Solution.cs)

 