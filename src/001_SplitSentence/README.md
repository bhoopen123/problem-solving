
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

 ## Known issues/limitations

 There are following limitations of the provided solution,
  - When a sentence has more than one space between two words, for example `This is a  sentence "having  more than one white space between words`.
  - If started or ending double is not provided, for example, `This sentence ""does not has one closing double quotes"`, and `This sentence "does not has one opening double quotes""`.

Both of these scenarios also make the sentence invalid, but I have kept these points which can be taken as enhancements for future.

