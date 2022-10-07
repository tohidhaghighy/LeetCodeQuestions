package util

import (
	tree "LeetCodeQuestions/Question01/util"
)

func ConvertListToTreeNode(list []int) tree.TreeNode {
	root := new(tree.TreeNode)
	if len(list) == 0 {
		return root
	}
	root.Val = list[0]
	for i := 1; i < len(list); i++ {
		currentNode := new(tree.TreeNode)
		if i%2 == 1 {
			if list[i] > 0 {
				currentNode.Val = list[i]
				root.Left = currentNode
			}
		}
		if i%2 == 0 {
			if list[i] > 0 {
				currentNode.Val = list[i]
				root.Right = currentNode
			}
			if root.Left != nil {
				root = root.Left
			} else {
				root = root.Right
			}
		}
	}
	return root
}
