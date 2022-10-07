package main

import (
	util "LeetCodeQuestions/Utilities"
)

/*
  by : Tohid haghighi
  https://leetcode.com/problems/binary-tree-inorder-traversal/solution/
  Approach 1: Recursive Approach
  Approach 2: Iterating method using Stack

*/

func TraverseInorder_Recursive(rootNode *TreeNode, list []int) []int {
	if rootNode != nil {
		if rootNode.Left != nil {
			TraverseInorder_Recursive(rootNode.Left, list)
		}
		list = append(list, rootNode.Val)
		if rootNode.Right != nil {
			TraverseInorder_Recursive(rootNode.Right, list)
		}
	}
	return list
}

func TraverseInorder_Iterate(tree *TreeNode, list []int) []int {
	stack := new(util.Stack)
	curr := tree
	for curr != nil || stack.Count() > 0 {
		for curr != nil {
			stack.Push(curr)
			curr = curr.Left
		}
		curr = stack.Pop()
		list = append(list, curr.Val)
		curr = curr.Right
	}
	return list
}
