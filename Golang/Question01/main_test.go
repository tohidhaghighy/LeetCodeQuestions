package main

import (
	"testing"
	"github.com/stretchr/testify/assert"
	util "LeetCodeQuestions/Utilities"
)

type TestParameter struct{
	argument []int
	expected []int
}

func TestTraverseInorder(t *testing.T) {

	testCases := map[string]TestParameter{
		"test1": TestParameter{
			argument: []int{1,2},
			expected: 2,
		},
		"test2": TestParameter{
			argument: []int{1,2,nil,4,5},
			expected: 4,
		}
	}

	for name, e := range testCases{
		listtonode:=new(util.ConvertListToTreeNode)
		actual := TraverseInorder_Recursive(listtonode.ConvertListToTreeNode(e.argument))
		assert.Equal(len(actual), e.expected)
	}
}