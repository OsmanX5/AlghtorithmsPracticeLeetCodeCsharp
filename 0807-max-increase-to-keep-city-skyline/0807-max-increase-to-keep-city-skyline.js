/**
 * @param {number[][]} grid
 * @return {number}
 */
var maxIncreaseKeepingSkyline = function(grid) {
    let res=0;
    
    let n = grid.length,m = grid[0].length;
    let maxAtRow = new Array(n).fill(0).map(
        ( _,i)=> grid[i].reduce( (res,val) => Math.max(res,val))
    );
    let maxAtCol = new Array(m).fill(0).map(
        (_, i) => grid.reduce((maxVal, row) => Math.max(maxVal, row[i]), -Infinity)
    );
    for(let i=0;i<n;i++)
        for(let j=0;j<m;j++)
            res+=  Math.min(maxAtRow[i],maxAtCol[j]) - grid[i][j];
    return res;
};