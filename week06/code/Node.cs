public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {

        if (value == Data){
            return;
        }
        
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

    public bool Contains(int value) {
        // TODO Start Problem 2

        if (value == Data){
            return true;
        }
        
        else if (value < Data) {
            if (Left is null)
                return false;
            else
                return Left.Contains(value);
        }
        else{
            if (Right is null)
                return false;
            else
                return Right.Contains(value);
        }
        
    }

    public int GetHeight() {
        // TODO Start Problem 4

        int height = 0;
        int rightHeight = 0;
        int leftHeight = 0;

        if (Right is null & Left is null){
            height = 1;
            return height;
        }
        
        if (Right is not null){

           rightHeight += 1; 
           return Right.GetHeight();
        }
        
        else if (Right is null){
            return 0;
        }

        if (Left is not null){
                leftHeight += 1; 
                return Left.GetHeight();
            }

        else if (Left is null){
            return 0;
        }


        if (rightHeight > leftHeight){

            height = rightHeight;
            return height;
        }

        else if (rightHeight < leftHeight){

            height = leftHeight;
            return height;
        }
        return height;
    }
}