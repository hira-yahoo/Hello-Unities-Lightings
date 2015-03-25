public class PositionOfSatellite {

	private float horizontalAngle;
	private float verticalAngle;
	private float distance;

	public PositionOfSatellite(float horizontalAngle, float verticalAngle, float distance) {
		this.horizontalAngle = horizontalAngle;
		this.verticalAngle = verticalAngle;
		setDistance (distance);
	}

	public float getHorizontalAngle() {
		return this.horizontalAngle;
	}

	public float getVerticalAngle() {
		return this.verticalAngle;
	}

	public void increaseHorizontalAngle(float angle) {
		this.horizontalAngle += angle;
	}

	public void setDistance(float distance) {
		this.distance = distance;
	}

	public float getDistance() {
		return this.distance;
	}



}
