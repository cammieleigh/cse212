public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value == Left?.Data || value == Right?.Data) {
            return;
        }
        else {
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
        }

    }


    public bool Contains(int value) {
        // TODO Start Problem 2
  
         if (value < Data) {
            if (Left is not null){
                if (value == Left?.Data){
                    return true;
                }
                else if (Left is null){
                    return false;
                }
                else{
                    
                    Left.Contains(value);
                }
                
            }
         }
         
         else if (value > Data) {
            if (Right is not null){
                if (value == Right?.Data){
                    return true;
                }
                 else if (Right is null){
                    return false;
                }
                else{
                    Right.Contains(value);
                }
          
         }
       
    }
return false;
         }


    public int GetHeight() {

            int leftCount = 0;
            int rightCount = 0;
        // TODO Start Problem 4
        // Console.WriteLine(leftCount);
        // Console.WriteLine(rightCount);
      
        if (Left is null && Right is null)
        {
            return 1;
        }
            else{ 
                if(Left is not null){

            leftCount++;
            // Console.WriteLine(leftCount);
            Left?.GetHeight();
        }
        else if (Right is not null){

            rightCount++;
            //Console.WriteLine(rightCount);
            Right?.GetHeight();
            
        }
        if (leftCount > rightCount){
            return leftCount + 1;
        }
        else{
            return rightCount + 1;
        }

        }
    

    }
}