import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import java.sql.*;
import net.proteanit.sql.DbUtils;
import javax.swing.table.DefaultTableModel;
public class Default extends JFrame  implements  ActionListener,ItemListener{
	Container container = getContentPane();

	JPanel innerContainer;

	public Default(){
		innerContainer = new JPanel();
		innerContainer.setLayout(new BorderLayout(5,5));
		container.setLayout(new FlowLayout());

		// Form Element Start 

		// Form Element End 


		// Bind Element Start 


		// Bind Element End 

		container.add(innerContainer);
		setSize(600,400);
		innerContainer.setPreferredSize(new Dimension(590,390));
		setVisible(true);
		setTitle("Mak ko IJO");
	}
	public static void main(String[] args) {
		Default app = new Default();
		app.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}
	@Override
	public void actionPerformed(ActionEvent e) {}
	@Override
	public void itemStateChanged(ItemEvent e){}
}
