import java.awt.*;
import java.awt.event.*;
import javax.swing.border.LineBorder;
import javax.swing.*;
public class gridbagdesigner extends JFrame {
	Container container = getContentPane();
	JPanel innerContainer;
	//PLEASE_DO_NOT_DELETE_OR_MODIFY_THIS_LINE_ELEMENT_DECLARATION
	public gridbagdesigner(){
		innerContainer = new JPanel();
		innerContainer.setLayout(new GridBagLayout());
		container.setLayout(new GridLayout(1,1));
		GridBagConstraints c = new GridBagConstraints();  ;
		 innerContainer.setLayout(new GridBagLayout());  
 		LineBorder border = new LineBorder(Color.RED, 3);		 JPanel GridBagLayout_0_0_Pnl = new JPanel(new GridLayout(0,1));
		 JLabel lblGridBagLayout_0_0_Pnl = new JLabel("GridBagLayout_(0)_P0_100%",SwingConstants.CENTER);
		GridBagLayout_0_0_Pnl.setBorder(border);
		GridBagLayout_0_0_Pnl.add(lblGridBagLayout_0_0_Pnl);
		  c.weightx = 1;
		  c.fill = GridBagConstraints.BOTH;
  		  c.gridx = 0; 
 		  c.gridy = 0;
 		  c.gridheight = 1;
		  c.gridwidth = 1;
		 c.ipadx = 0;
		 c.ipady = 0;
		innerContainer.add(GridBagLayout_0_0_Pnl, c); 
 		 JPanel GridBagLayout_0_1_Pnl = new JPanel(new GridLayout(0,1));
		 JLabel lblGridBagLayout_0_1_Pnl = new JLabel("GridBagLayout_(0)_P1_100%",SwingConstants.CENTER);
		GridBagLayout_0_1_Pnl.setBorder(border);
		GridBagLayout_0_1_Pnl.add(lblGridBagLayout_0_1_Pnl);
		  c.weightx = 1;
		  c.fill = GridBagConstraints.BOTH;
  		  c.gridx = 1; 
 		  c.gridy = 0;
 		  c.gridheight = 1;
		  c.gridwidth = 1;
		 c.ipadx = 0;
		 c.ipady = 0;
		innerContainer.add(GridBagLayout_0_1_Pnl, c); 
 	//PLEASE_DO_NOT_DELETE_OR_MODIFY_THIS_LINE_BIND_SETTING
	c.fill = GridBagConstraints.HORIZONTAL;
	c.gridx = 0;
	c.gridy = 100;
	c.weighty = 1;
	c.weightx = 0;
	c.anchor = GridBagConstraints.PAGE_END;
	innerContainer.add(new JLabel(" "), c);
		container.add(innerContainer);
		setSize(600,400);
		innerContainer.setPreferredSize(new Dimension(600,400));
		setVisible(true);
		setTitle("GridBagLayout Design Sample");
	}	public static void main(String[] args) {
		gridbagdesigner app = new gridbagdesigner();
		app.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}
}
