QUnit.test( "hello test", function( assert ) {
    assert.ok( 1 == "1", "Passed!" );
});

QUnit.test( "function test1", function( assert ) {
    var result = fixage([5,15,2,78,5,4]);
    assert.equal(result,"NA","ok");

});

QUnit.test( "function test2", function( assert ) {
    var result = fixage([5,15,25,78,59,45]);
    assert.equal(result,[25,59,45],"ok");

});