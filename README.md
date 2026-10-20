# in-class-activities
## Devlogs
### W1
#### Activity 1
1. The camera no longer follows the cat it stays in place because it is no longer a child of the Cat GameObject, so it does not automatically follows the cat. 
2. https://wendywu050216.itch.io/in-class-acitivity-1

### W2
#### Question 1
The r, b, and g varaibles are float instead of other variable types because they indicate the rbg values for the ball color which could go beyond 3 digits after decimal. Therefore, a float can store that information compared to other variable types. Like for int variable type it can only store whole number, for string you would need to convert it to numbers for using it (using it would be more complicated), and for boolean it would need to be true or false, which also does not work.
#### Question 2
_bounce variable is int instead of ther variable type because number of bounces are only whole numbers you can't get half a jump. Therefore int is used instead of the other variable types (explanation for bool and string reasons in **question 1** works here as well).
#### Question 3
The error in Step 4 of Part 2 was a complier error which tells you that the line is not closed properly. In this case, a missing semicolon was causing this issue. 

### W3
#### Activity 1:
Table 8
1. the input would be int and boolean, int representing the current friendship level, and boolean representing the flag that teels you whether or not the player knows the character's secret. The output would be a string.
2. The input would be a float. The return type is void. 
3. The input would be a float and the output would be a boolean. 

#### Activity 2:
Table 8 <br>
Class are like a cat's DNA and the memeber variables can be their personality/traits. Some can be friendly, some can have green eyes and more. The Component is the cat itself, by editing the class you will be able to modify the cat's behavior and DNA.

#### Part 3:
Because everytime we are multiplying the color by 1.5 if the average speed is above the threshold. Therefore as balls bounce faster and faster, the multiplication makes the number of color value grow causing it to become extremely brighter. 

### W4
#### Question 1:
Team number3: For our team we came up with that the rigidbody should go to soccer and the cat because these are the only two objects in the game that needs to move which involves physic. The goal on the other hand does not require that. For the Is Trigger check, we chose the goal because as goal would not be moving collision would only happens when a ball collides into it.  
#### Question 2:
I think the only thing that did not work for me the first time would be forgotting to freeze the rotation of the cat causing it to fall while walking. I fixed it by freezing the rotation. 
 
## Open-Source Assets
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 