/** @jsx React.DOM */

var MappingTemplate = React.createClass({
	getInitialState: function() {
		return {data: {Foo: '', Bar: ''}};
	},
	componentWillMount: function() {
		var xhr = new XMLHttpRequest();
		xhr.open('get', this.props.url, true);
		xhr.onload = function() {
			var data = JSON.parse(xhr.responseText);
			this.setState({ data: data });
		}.bind(this);
		xhr.send();
	},
	render: function(){
		return (
			<div className="row">
			<div className="col-md-3">
				<label> Foo </label> 
			</div>
			<div className="col-md-3">
				{this.state.data.Foo}
			</div>
			<div className="col-md-3">
				<label> Bar </label>
		    </div>
			 <div className="col-md-3">
				{this.state.data.Bar} 
			</div>
		  </div>
        );
	}
});

React.render(
    <MappingTemplate url="/MappingExampleOne" />,
    document.getElementById('mapping-example-one')
);

React.render(
    <MappingTemplate url="/MappingExampleTwo" />,
    document.getElementById('mapping-example-two')
);

React.render(
    <MappingTemplate url="/MappingExampleThree" />,
    document.getElementById('mapping-example-three')
);

React.render(
    <MappingTemplate url="/MappingExampleFour" />,
    document.getElementById('mapping-example-four')
);