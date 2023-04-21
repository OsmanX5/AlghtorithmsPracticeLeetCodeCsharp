/**
 * @param {number[][]} points
 * @param {number[][]} queries
 * @return {number[]}
 */
var countPoints = function(points, queries) {
    let res =[]
    for (let i = 0; i < queries.length; i++) {
        const queire = queries[i];
        let x1=queire[0],y1=queire[1],r =queire[2];
        res[i] = points.filter(
            point =>
            {
                let x2 = point[0],y2 = point[1];
                let dist = Math.sqrt( (x2-x1)**2 + (y2-y1)**2 );
                return dist<=r;
            }
        ).length;
    }
    return res;
};